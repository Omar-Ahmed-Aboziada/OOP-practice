using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ITI_OOP.OOP_Company
{
    internal class department
    {
        public string Department_Name { private set; get; }
        public string Department_Location { private set; get; }
        public int Department_ID { private set; get; }
        private const int MAX_ALLOWED_EMPLOYESS = 20 ;  
        private const int MAX_ALLOWED_MANGERS = 2 ;  
        private employee[] Employees { set; get; }
        private manager[] Managers { set; get; }
        private int Index = 0; 
        public department(int id , string name,string location) 
        {
            Department_ID = id ;
            Department_Name = name ;
            Department_Location = location ;
            Employees = new employee[MAX_ALLOWED_EMPLOYESS];
            Managers = new manager[MAX_ALLOWED_MANGERS];
        }
        private bool Can_Employees_Assign_To_Department(employee e)
        {
            return Index == MAX_ALLOWED_EMPLOYESS? false : true;
        }
        public void Assign_Employees_To_Department(employee e)
        {
            if (Can_Employees_Assign_To_Department(e))
            {
                Employees[Index] = e; 
                Index++;
            }
            else
            {
                throw new Exception($"The employee {e.Employee_Name} can't be assigned because the department has reached the maximum number of employees !");
            }
        }
        private bool Can_Managers_Assign_To_Department(manager m)
        {
            return Index == MAX_ALLOWED_MANGERS ? false : true;
        }
        public void Assign_Managers_To_Department(manager m)
        {
            if (Can_Managers_Assign_To_Department(m))
            {
                Managers[Index] = m;
                Index++;
            }
            else
            {
                throw new Exception($"The Manager {m.Manager_Name} can't be assigned because the department has reached the maximum number of Managers !");
            }
        }
        public void Get_Department_ordinary_Employees(department d)
        {
            foreach (employee e in Employees)
            {
                if(e!=null)
                Console.WriteLine($"ordinary empolyee : {e.Employee_Name}");
            }
        }
        public void Get_Department_Managers(department d)
        {
            foreach (manager m in Managers)
            {
                if(m!=null)
                Console.WriteLine($"Manager empolyee : {m.Manager_Name}");
            }
        }
    }
}
