using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3InheritanceAccesModifiersAutoPropStatic.Exercise4
{
    public class Course
    {
        private string courseName;
        private List<int> grades;

        public Course(string courseName)
        {
            this.courseName = courseName;
            grades = new List<int>();
        }

        public string getCourseName()
        {
            return courseName;
        }

        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public List<int> getGrades()
        {
            return grades;
        }
        public void setGrades(List<int> grades)
        {
            this.grades = grades;
        }

        //add grades for a specific course
        public void AddGrades(int grade)
        {
            grades.Add(grade);

        }
        //delete grades for a specific course
        public void RemoveGrades(int grade)
        {
            grades.Remove(grade);
            //grades.RemoveAt(2);
            //[removeAt 1, 2, 3]
        }

    }
}
