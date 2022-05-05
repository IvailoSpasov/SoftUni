using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;

namespace Bakery.Core.Contracts
{
    public class Controller : IController
    {
        private List<IBakedFood> foods;
        private List<IDrink> drinks;
        private List<ITable> tables;
        private decimal income;

        public Controller()
        {
            this.foods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }

        public string AddFood(string type, string name, decimal price)
        {
            IBakedFood food;
            if (type == "Bread")
            {
                food = new Bread(name, price);
            }
            else
            {
                food = new Cake(name, price);
            }

            foods.Add(food);
            return $"Added {name} ({type}) to the menu";
        }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink;
            if (type == "Tea")
            {
                drink = new Tea(name, portion, brand);
            }
            else
            {
                drink = new Water(name, portion, brand);
            }
            drinks.Add(drink);
            return $"Added {name} ({brand}) to the drink menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table;
            if (type == "InsideTable")
            {
                table = new InsideTable(tableNumber, capacity);
            }
            else
            {
                table = new OutsideTable(tableNumber, capacity);
            }
            tables.Add(table);
            return $"Added table number {tableNumber} in the bakery";
        }

        public string ReserveTable(int numberOfPeople)
        {
            ITable table = tables.FirstOrDefault(x => x.IsReserved == false && x.Capacity >= numberOfPeople);
            if (table == null)
            {
                return $"No available table for {numberOfPeople} people";
            }
            else
            {
                table.Reserve(numberOfPeople);
                return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
            }
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IBakedFood food = foods.FirstOrDefault(x => x.Name == foodName);
            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }
            else if (food == null)
            {
                return $"No {foodName} in the menu";
            }
            else
            {
                table.OrderFood(food);
                return $"Table {tableNumber} ordered {foodName}";
            }
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IDrink drink = drinks.FirstOrDefault(x => x.Name == drinkName && x.Brand == drinkBrand);
            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }
            else if (drink == null)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }
            else
            {
                table.OrderDrink(drink);
                return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
            }
        }

        public string LeaveTable(int tableNumber)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            decimal bill = table.GetBill();
            table.Clear();
            income += bill;
            return $"Table: {tableNumber}\nBill: {bill:f2}";
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var table in tables.Where(x=>x.IsReserved==false))
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            return $"Total income: {income:f2}lv";
        }
    }
}
