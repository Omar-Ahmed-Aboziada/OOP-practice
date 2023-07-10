using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ITI_OOP.OOP_Company
{
    internal class Programe
    {
        public static void Main(string[] args)
        {

            employee Omar = new employee(1,"Omar");
            employee Ali = new employee(2,"Ali");
            employee Amr = new employee(3,"Amr");
           
            manager Emad = new manager(1,"Emad");
           
            department Finance = new department(1, "Finance","Sohag");

            Omar.Assign_To_Manager(Emad);
            Ali.Assign_To_Manager(Emad);
            Amr.Assign_To_Manager(Emad);

            Emad.Assign_To_employee(Omar);
            Emad.Assign_To_employee(Ali);
            Emad.Assign_To_employee(Amr);

            Finance.Assign_Managers_To_Department(Emad);

            Finance.Assign_Employees_To_Department(Omar);
            Finance.Assign_Employees_To_Department(Ali);
            Finance.Assign_Employees_To_Department(Amr);

            Console.WriteLine("The ordinary employees :");
            Finance.Get_Department_ordinary_Employees(Finance);

            Console.WriteLine("=======================");

            Console.WriteLine("The Managers employees :");
            Finance.Get_Department_Managers(Finance);

            Console.WriteLine("=======================");

            Console.WriteLine($"{Emad.Manager_Name} managed employees :");
            Emad.Get_My_employees(Emad);

            Console.WriteLine("=======================");

            Omar.Get_My_Manager(Omar);
            Ali.Get_My_Manager(Ali);
            Amr.Get_My_Manager(Amr);


        }
    }
}
