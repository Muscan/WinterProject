using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3InheritanceAccesModifiersAutoPropStatic.Exercise4
{
    class Student
    {
        private List<Course> courses;
        private string studentName;

        public Student(string studentName)
        {
            this.studentName = studentName;
            //instantiate the Courses list
            courses = new List<Course>();
        }

        public string getStudentName()
        {
            return studentName;
        }
        public void setStudentName(string studentName)
        {
            this.studentName = studentName;
        }

        public List<Course> getCourses()
        {
            return courses;
        }

        public void setCourses(List<Course> courses)
        {
            this.courses = courses;
        }

        public void AddCourses(Course course)
        {
            courses.Add(course);
        }

        public void DeleteCourses(Course course)
        {
            //What is the difference between Remove/Clear and removeAt
            courses.Remove(course);
        }

        public void SetAStudentGradeForVariousCourses(Course course, List<int> grades)
        {
            course.setGrades(grades);

        }

        public List<int> GetCoursesGradesForAStudent(Course course)
        {
            return course.getGrades();
        }

    }
}
