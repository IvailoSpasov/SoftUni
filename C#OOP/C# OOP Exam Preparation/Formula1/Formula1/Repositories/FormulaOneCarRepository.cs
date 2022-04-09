using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository : IRepository<IFormulaOneCar>
    {
        private List<IFormulaOneCar> models;

        public FormulaOneCarRepository()
        {
            this.models = new List<IFormulaOneCar>();
        }

        public IReadOnlyCollection<IFormulaOneCar> Models => this.models;

        public void Add(IFormulaOneCar model)
        {
            this.models.Add(model);
        }

        public bool Remove(IFormulaOneCar model)
        {
            return this.models.Remove(model);
        }

        public IFormulaOneCar FindByName(string name)
        {
            IFormulaOneCar car = models.FirstOrDefault(x => x.Model == name);
            return car;
        }
    }
}
