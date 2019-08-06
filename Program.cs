using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet myBuff = new Buffet();
            // Food myFood = myBuff.Serve();
            // System.Console.WriteLine(myFood.Name);
            Ninja Marco = new Ninja();
            while( !Marco.isFull )
            {
                Marco.Eat(myBuff.Serve());
            }
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food( string Name, int Calories, bool IsSpicy, bool IsSweet )
        {
            this.Name = Name;
            this.Calories = Calories;
            this.IsSpicy = IsSpicy;
            this.IsSweet = IsSweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Strawberries", 200, false, true),
                new Food("Jalapenoes", 200, true, false),
                new Food("Chips", 750, false, false),
                new Food("Fish", 300, false, false),
                new Food("Candy", 900, false, false),
                new Food("Spicy Fries", 600, true, false),
                new Food("Burger", 400, false, false),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            int randItem = rand.Next(0, Menu.Count);
            return Menu[randItem];
            
        }
    }
    class Ninja
    {
        private int caloriesIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            caloriesIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool isFull
        {
            get
            {
                return caloriesIntake > 1200;
            }
        }
        public void Eat(Food item)
        {
            if (isFull)
            {
                System.Console.WriteLine("The ninja is full and can not eat anymore");
            }
            else
            {
                caloriesIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"{item.Name}, Spicy:{item.IsSpicy}, Sweet:{item.IsSweet}");
            }
        }
    }

}
