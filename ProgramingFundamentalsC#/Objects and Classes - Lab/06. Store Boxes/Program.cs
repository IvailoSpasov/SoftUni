using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();
            while (input[0] != "end")
            {
                Box box = new Box();
                box.SerialNumber = input[0];
                box.Item.Name = input[1];
                box.Item.Price = decimal.Parse(input[3]);
                box.Quantity = int.Parse(input[2]);
                box.PriceForBox = box.Item.Price * box.Quantity;
                boxes.Add(box);

                input = Console.ReadLine().Split();
            }

            List<Box> orderedBoxes = new List<Box>(boxes.OrderByDescending(o => o.PriceForBox));

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceForBox { get; set; }
    }
}
