using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops;
using Easter.Models.Workshops.Contracts;
using Easter.Repositories;
using Easter.Repositories.Contracts;

namespace Easter.Core.Contracts
{
    public class Controller : IController
    {
        private IRepository<IBunny> bunnys;
        private IRepository<IEgg> eggs;
        private int countColoredEggs;

        public Controller()
        {
            bunnys = new BunnyRepository();
            eggs = new EggRepository();
        }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType != "HappyBunny" && bunnyType != "SleepyBunny")
            {
                throw new InvalidOperationException("Invalid bunny type.");
            }

            IBunny bunny;
            if (bunnyType == "HappyBunny")
            {
                bunny = new HappyBunny(bunnyName);
            }
            else
            {
                bunny = new SleepyBunny(bunnyName);
            }
            bunnys.Add(bunny);
            return $"Successfully added {bunnyType} named {bunnyName}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IBunny bunny = bunnys.FindByName(bunnyName);
            if (bunny == null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }
            IDye dye = new Dye(power);
            bunny.Dyes.Add(dye);
            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            IEgg egg = new Egg(eggName, energyRequired);
            eggs.Add(egg);
            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            List<IBunny> bunnysToWork = bunnys.Models.OrderByDescending(x=>x.Energy).Where(x => x.Energy >= 50).ToList();

            if (bunnysToWork.Count == 0)
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }

            IEgg egg = eggs.FindByName(eggName);

            foreach (var bunny in bunnysToWork)
            {
                IWorkshop workshop = new Workshop();
                workshop.Color(egg,bunny);
                if (bunny.Energy==0)
                {
                    bunnys.Remove(bunny);
                }
                if (egg.IsDone())
                {
                    break;
                }
            }

            string status = "not done";
            if (egg.IsDone())
            {
                status = "done";
                countColoredEggs++;
            }

            return $"Egg {eggName} is {status}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{countColoredEggs} eggs are done!");
            sb.AppendLine("Bunnies info:");
            foreach (var bunny in bunnys.Models)
            {
                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: {bunny.Energy}");
                sb.AppendLine($"Dyes: {bunny.Dyes.Count(x => x.IsFinished() == false)} not finished");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
