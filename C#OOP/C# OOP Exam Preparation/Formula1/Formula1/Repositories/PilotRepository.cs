using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
    public class PilotRepository : IRepository<IPilot>
    {
        private List<IPilot> models;

        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }

        public IReadOnlyCollection<IPilot> Models => this.models;

        public void Add(IPilot model)
        {
            this.models.Add(model);
        }

        public bool Remove(IPilot model)
        {
            return this.models.Remove(model);
        }

        public IPilot FindByName(string name)
        {
            IPilot pilot = this.models.FirstOrDefault(x => x.FullName == name);
            return pilot;
        }
    }
}
