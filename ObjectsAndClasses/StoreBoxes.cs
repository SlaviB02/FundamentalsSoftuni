using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace ConsoleApp83
{
    
    public class Box
    {
      public Box(string serialNumber,Item item,int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = quantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
       public int ItemQuantity { get; set; }
        public decimal PriceForBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }

    }
    public class Item
    {
        public Item(string name,decimal price)
        {
            Name = name;
            Price = price;
        }
      public  string Name { get; set; }
       public decimal Price { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
           while(true)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0]=="end")
                {
                    break;
                }
                string serialNumber = command[0];
                string itemName = command[1];
                int itemQuantity = int.Parse(command[2]);
                decimal itemPrice = decimal.Parse(command[3]);
                Item Item = new Item(itemName,itemPrice);
                Box box = new Box(serialNumber, Item, itemQuantity);
                boxes.Add(box);
               
            }
            foreach (var box in boxes.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${ box.PriceForBox:F2}");
            }
        }
    }
}
