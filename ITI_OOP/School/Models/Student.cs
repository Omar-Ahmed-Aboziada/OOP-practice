using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITI_OOP.School.Models
{
    internal class Student
    {
        private string Name { get; set; }
        private Course[] Courses {set; get; }
        private int NextCourcesIndex=0;
        public static int MAX_ALLOWED_COURCES=4;
        public Student(string name)
        {
            Courses = new Course[MAX_ALLOWED_COURCES];
            Name = name;
        }
        public void Enroll(Course course)
        {
            if (NextCourcesIndex == MAX_ALLOWED_COURCES)
            {
                throw new Exception("reached the max allowed cources");
            }
            
            if (IsCourseEnrolled(course,this.Courses))
            {
                 throw new Exception($"already enrolled in {course.Name}");
            }

            this.Courses[this.NextCourcesIndex++]=course;
            course.EnrollStudent(this);
        }

        private static bool IsCourseEnrolled(Course course, Course[] cources)
        {
            foreach (Course c in cources)
            {
                if (c != null && course.Id == c.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintCources()
        {
            for (int i=0;i<NextCourcesIndex;i++)
            {
                Console.WriteLine(this.Courses[i].Name);
            }
        }
    }
}
