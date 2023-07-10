using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_OOP.School.Models
{
    internal class Course
    {
        public int Id { get;private set; }
        public string Name { get;private set; }
        private Student[] Students { set;get; }
        private const int MAX_ENROLLED_STUDENTS=100;
        private int NextIndex = 0;
        public Course(int id,string name) { 
            this.Name = name;
            this.Id = id;   
            Students=new Student[MAX_ENROLLED_STUDENTS];
        }

        public void EnrollStudent(Student student)
        {
            //logic here 
            if (!CanIEnroll(student))
            {
                throw new Exception($"{this.Name} has reached the max allowed students");
            }
            this.Students[NextIndex++] = student;
        }

        public bool CanIEnroll(Student student)
        {
            return this.NextIndex != MAX_ENROLLED_STUDENTS;
        }

    }
}
