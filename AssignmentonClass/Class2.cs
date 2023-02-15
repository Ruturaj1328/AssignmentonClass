using AssignmentonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentonClass
{
    public class Food
    {
        private string name;
        private double price;
        private int quantity;

        public Food(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void Discount(int discount)
        {
            double amt = (double)price / 100 * discount;
            price = price - amt;
        }

        public string Print()
        {
            return $"food name is {name} and  price is {price}";
        }
    }
    public class Class2
    {
        static void Main(string[] args)
        {

            Food f1 = new Food("rice",1500,30);
             Console.WriteLine(f1.Print());

            Food f2 = new Food("rice", 1500, 30);
            f2.Discount(5);
            Console.WriteLine(f2.Print());
        }
    }
}

