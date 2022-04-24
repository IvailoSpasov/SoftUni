using System;
using System.Collections.Generic;
using System.Text;
using Formula1.Models.Contracts;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;

        public Pilot(string fullName)
        {
            FullName = fullName;
            CanRace = false;
        }
        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid pilot name: {value}.");
                }

                this.fullName = value;
            }
        }
        public IFormulaOneCar Car
        {
            get => this.car;
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot car can not be null.");
                }

                this.car = value;
            }
        }
        public int NumberOfWins { get; set; }

        public bool CanRace { get; set; }

        public void AddCar(IFormulaOneCar car)
        {
            Car = car;
            CanRace = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }

        public override string ToString()
        {
            return $"Pilot {FullName} has {NumberOfWins} wins.";
        }
    }
}
