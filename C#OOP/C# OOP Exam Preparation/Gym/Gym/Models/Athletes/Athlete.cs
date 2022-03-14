using System;
using System.Collections.Generic;
using System.Text;
using Gym.Models.Athletes.Contracts;

namespace Gym.Models.Athletes
{
   public abstract class Athlete : IAthlete
   {
       private string fullName;
       private string motivation;
       private int stamina;
       private int numberOfMedals;

        public Athlete(string fullName, string motivation, int numberOfMedals, int stamina)
        {
            this.FullName = fullName;
            this.Motivation = motivation;
            this.NumberOfMedals = numberOfMedals;
            this.Stamina = stamina;
        }

        public string FullName
        {
            get => this.fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Athlete name cannot be null or empty.");
                }

                this.fullName = value;
            }
        }
        public string Motivation
        {
            get => this.motivation;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The motivation cannot be null or empty.");
                }

                this.motivation = value;
            }
        }

        public int Stamina
        {
            get => this.stamina;
            set
            {
                this.stamina = value;
            }
        }

        public int NumberOfMedals
        {
            get => this.numberOfMedals;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Athlete's number of medals cannot be below 0.");
                }

                this.numberOfMedals = value;
            }
        }
        public abstract void Exercise();
        
    }
}
