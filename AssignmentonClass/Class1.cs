using AssignmentonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentonClass
{
    public class Student
    {
        private int sub1;
        private int sub2;
        private int sub3;
        private int total;
        private double percentage;

        public Student(int sub1, int sub2, int sub3)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }

        public void Calculation()
        {
            total = sub1 + sub2 + sub3;
            percentage = (double)total / 3;
        }
        public string print()
        {
            return $"total is {total} and percentage is {percentage}";
        }
    }
}
public class Class1
{
    static void Main(string[] args)
    {
        Student stud = new Student(55, 65, 70);
        stud.Calculation();
        Console.WriteLine(stud.print());
    }
}


