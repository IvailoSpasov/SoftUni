using System;
using System.Collections.Generic;
using System.Text;
using Easter.Models.Dyes.Contracts;

namespace Easter.Models.Dyes
{
    public class Dye : IDye
    {
        private int power;

        public Dye(int power)
        {
            Power = power;
        }

        public int Power
        {
            get => this.power;
            set
            {
                if (value < 0)
                {
                    this.power = 0;
                }

                this.power = value;
            }
        }

        public void Use()
        {
            Power -= 10;
        }

        public bool IsFinished()
        {
            if (Power == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
