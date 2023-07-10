using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_OOP.OOP_Company
{
    internal class manager
    {
        public int Manager_ID { private set; get; }
        public string Manager_Name { private set; get; }
        private double Manager_Base_Salary { set; get; }
        private employee[] employees { set; get; }
        private const int MAX_MANAGED_EMPLOYESS = 10;
        private int Index = 0;
        public manager(int id, string name)
        {
            Manager_ID = id;
            Manager_Name = name;
            employees = new employee[MAX_MANAGED_EMPLOYESS];
        }
        private bool Can_I_Manage(employee e)
        {           
            return Index == MAX_MANAGED_EMPLOYESS? false : true ; 
        }
        public void Assign_To_employee(employee e)
        {
            if (Can_I_Manage(e))
            {
                employees[Index] = e;
                Index++;
            }
            else
            {
                throw new Exception($"The Manager {Manager_Name} has reached the maximum managed_employees !");
            }
        }
        public void Get_My_employees (manager m ) 
        {
            foreach (employee e in employees)
            {
                if (e != null)
                    Console.WriteLine($"managed employee : {e.Employee_Name}");
            }
        }


    }
}
