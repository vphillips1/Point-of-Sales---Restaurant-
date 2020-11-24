using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Point_of_Sales_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to VV Wings!\n Here is the menu:");

            

            string menuItems = @"C:\Users\verke\source\repos\Point of Sales Project\Menu Items.txt";

            List<string> paths = File.ReadAllLines(menuItems).ToList();
            foreach (var path in paths)
            {
                Console.WriteLine(paths);
            }
            
            Console.ReadLine();
            
        }

    }

    public class RestaurantMenu
    {
        public string Name;
        public string Category;
        public string Description;
        public int Price;



        public RestaurantMenu(string name, string category, string description, int price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }
        

        

    }

}
