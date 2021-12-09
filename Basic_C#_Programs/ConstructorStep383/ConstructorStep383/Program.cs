using System;
using System.Collections.Generic;

namespace ConstructorStep383
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a cons string named "courseName"
            const string courseName = "C# and .Net Course";

            //Create a list of courses using the keyword "var", and add 4 items
            var courseList = new List<Courses>()
            {
                new Courses(courseName),
                new Courses(courseName, "Libraries and Additional C# Features", "Additional Features", 383),
                new Courses(courseName, "Libraries and Additional C# Features", "Additional Features", 101),
                new Courses(courseName)
            };

            //Print the curses on the console
            foreach( Courses course in courseList)
            {
                Console.WriteLine(course.ToString());
            }
            Console.ReadLine();
        }

        //The public class "Courses" is created
        public class Courses
        {
            //The constructor is chained with another, passing by default the first topics of the course
            public Courses(string course) : this(course, "Basic Programming Terms", "Course Overview", 1)
            {
            }

            //Another constructor
            public Courses(string course, string section, string subsection, int step)
            {
                Course = course;
                Section = section;
                Subsection = subsection;
                Step = step;
            }

            //Properties of curse
            public string Course;
            public string Section;
            public string Subsection;
            public int Step;

            //Override the ToString method, to customize the console output
            public override string ToString()
            {
                return string.Format("You are studying the {0} course, section {1}, subsection {2}, step {3}", Course, Section, Subsection, Step);
            }
        }
    }
}
