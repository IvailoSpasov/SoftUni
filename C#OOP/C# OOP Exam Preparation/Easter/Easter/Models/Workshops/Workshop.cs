using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {

        }
        public void Color(IEgg egg, IBunny bunny)
        {
            while (bunny.Energy > 0 && bunny.Dyes.Any(x => x.IsFinished() == false))
            {
                egg.GetColored();
                bunny.Work();
                bunny.Dyes.FirstOrDefault(x => x.IsFinished() == false).Use();
                if (egg.IsDone())
                {
                    break;
                }
                
            }
        }
    }
}
