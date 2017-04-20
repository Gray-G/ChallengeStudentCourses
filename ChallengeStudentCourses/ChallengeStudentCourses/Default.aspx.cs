using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> courses = new List<Course>()
            {
                new Course {CourseId = 1, Name = "Biology", Students = new List<Student>
                    { new Student { StudentId = 1, Name = "Bob"}, new Student { StudentId = 2, Name = "Julie" } } },
                new Course {CourseId = 2, Name = "Physics", Students = new List<Student>
                    { new Student {StudentId = 3, Name = "Joe" }, new Student { StudentId = 4, Name = "Alexa"} } },
                new Course { CourseId = 3, Name = "English", Students = new List<Student>
                    { new Student { StudentId = 5, Name = "Katie" }, new Student { StudentId = 6, Name = "Steve"} } }
            };

            foreach (var course in courses)
            {
                resultLabel.Text += $"<br />Course name: {course.Name} - Course ID: {course.CourseId}";
                foreach (var student in course.Students)
                {
                    resultLabel.Text += $"<br />&nbsp;&nbsp;Student name: {student.Name} - Student ID: {student.StudentId}";
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course() { CourseId = 1, Name = "Biology" };
            Course course2 = new Course() { CourseId = 2, Name = "Physics" };
            Course course3 = new Course() { CourseId = 3, Name = "English" };   

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student { StudentId = 1, Name = "Bob", Courses = new List<Course> { course1, course2 } } },
                {2, new Student { StudentId = 2, Name = "Julie", Courses = new List<Course> { course2, course3 } } },
                {3, new Student { StudentId = 3, Name = "Henry", Courses = new List<Course> { course1, course3 } } } 
            };

            foreach (var student in students)
            {
                resultLabel.Text += $"<br />Student name: {student.Value.Name} - Student ID: {student.Value.StudentId}";
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += $"<br />&nbsp;&nbsp;Course name: {course.Name} - Course ID: {course.CourseId}";               
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student1 = new Student();
            student1.Name = "Bob";
            student1.StudentId = 5125;
            student1.Enrollments = new List<Enrollment>()
            {
                new Enrollment {Course = new Course {CourseId = 101, Name = "Biology" }, Grade = 95, Student = student1 },
                new Enrollment {Course = new Course {CourseId = 102, Name = "Calculus" }, Grade = 89, Student = student1 }
            };

            resultLabel.Text += $"<br />Student name: {student1.Name} - Student ID: {student1.StudentId}";
            foreach (var enrollment in student1.Enrollments)
            {
                resultLabel.Text += $"<br />&nbsp;&nbsp;Enrolled in: {enrollment.Course.Name} - Grade: {enrollment.Grade}";
            }
        }
    }
}