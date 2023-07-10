using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_OOP.OOP_Company
{
    internal class employee
    {
        public int Employee_ID {private set; get;}
        public string Employee_Name { private set; get;}
        private double Employee_Base_Salary { set; get;}
        private int Index = 0;
        private const int MAX_ALLOWED_MANAGERS = 1;
        private manager[] Managers; 
        public employee(int id,string name)
        {
            Employee_ID= id;
            Employee_Name= name;
            Managers = new manager[MAX_ALLOWED_MANAGERS];
        }
        private bool Can_I_Be_Managed(manager m)
        {
            return Index == MAX_ALLOWED_MANAGERS ? false : true;       
        }
        public void Assign_To_Manager(manager m)
        {
            if(Can_I_Be_Managed(m))
            {
                Managers[Index] = m;
                Index++; 
            }
            else
            {
                throw new Exception($"The Employee {Employee_Name} has reached the max managers !");
            }
        }
        public void Get_My_Manager(employee e)
        {
            foreach (manager m in Managers)
            {
                if(m!= null)
                Console.WriteLine($"the manager of {e.Employee_Name} is : {m.Manager_Name}");
            }
        }


    }
}
