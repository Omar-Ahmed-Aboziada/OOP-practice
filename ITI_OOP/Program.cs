using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ITI_OOP.School.Models;
namespace ITI_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Course math = new Course(1, "Math");

            //Student anas = new Student("anas ashraf");

            //if (math.CanIEnroll(anas))
            //{
            //    anas.Enroll(math);
            //    math.EnrollStudent(anas);
            //}
            //anas.PrintCources7y7();

            Change(out int z);

            Console.WriteLine(z);

        }

        public static bool Change(out int x)
        {
            x = 5;
            return true;
        }
    }
}
