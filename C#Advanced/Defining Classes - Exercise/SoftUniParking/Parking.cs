using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace SoftUniParking
{
    public class Parking
    {
        private int _capacity;
        private Dictionary<string, Car> cars;

        public Parking(int capacity)
        {
            _capacity = capacity;
            cars = new Dictionary<string, Car>();
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else
            {
                if (cars.Count == _capacity)
                {
                    return "Parking is full!";
                }
                else
                {
                    cars.Add(car.RegistrationNumber, car);
                   return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.ContainsKey(registrationNumber))
            {
                cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                if (cars.ContainsKey(number))
                {
                    cars.Remove(number);
                }
            }
        }
    }
}
