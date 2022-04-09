﻿using System;
using System.Collections.Generic;
using System.Text;
using Formula1.Models.Contracts;

namespace Formula1.Models
{
    public abstract class FormulaOneCar : IFormulaOneCar
    {
        private string model;
        private int horsepower;
        private double engineDisplacement;

        public FormulaOneCar(string model, int horsepower, double engineDisplacement)
        {
            Model = model;
            Horsepower = horsepower;
            EngineDisplacement = engineDisplacement;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException($"Invalid car model: {value}.");
                }

                this.model = value;
            }
        }

        public int Horsepower
        {
            get => this.horsepower;
            private set
            {
                if (value < 900 || value > 1050)
                {
                    throw new ArgumentException($"Invalid car horsepower: {value}.");
                }

                this.horsepower = value;
            }
        }

        public double EngineDisplacement
        {
            get => this.engineDisplacement;
            private set
            {
                if (value < 1.60 || value > 2.00)
                {
                    throw new ArgumentException($"Invalid car engine displacement: {value}.");
                }

                this.engineDisplacement = value;
            }
            
        }

        public double RaceScoreCalculator(int laps)
        {
            return EngineDisplacement / Horsepower * laps;
        }
    }
}
