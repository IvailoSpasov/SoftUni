﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Models.Equipment.Contracts;
using Gym.Repositories.Contracts;

namespace Gym.Repositories
{
    public class EquipmentRepository : IRepository<IEquipment>
    {
        private List<IEquipment> models;

        public EquipmentRepository()
        {
            this.models = new List<IEquipment>();
        }
        public IReadOnlyCollection<IEquipment> Models
        {
            get => this.models;
        }
        public void Add(IEquipment model)
        {
            this.models.Add(model);
        }

        public bool Remove(IEquipment model)
        {
            return this.models.Remove(model);
        }

        public IEquipment FindByType(string type)
        {
            IEquipment model = models.FirstOrDefault(x => x.GetType().Name == type);
            return model;
        }
    }
}
