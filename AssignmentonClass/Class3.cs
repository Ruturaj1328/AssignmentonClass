using AssignmentonClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentonClass
{

    public class Product
    {
        private int id;
        private string name;
        private int price;

       

        public int Id
        {
            get{ return id; }
            set{ id = value; }
        }

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public int Price
        {
            get{ return price; }
            set{ price = value; }
        }

        public string print()
        {
            return $"{id}--{name}-{price}";
        }
    }
}
internal class Class3
{
    static void Main(string[] args)
    {
       Product p= new Product();
        p.Id = 1;
        p.Name = "Mouse";
        p.Price = 599;

        Console.WriteLine(p.print());
    }
}


