using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Engels" };

                ctx.Students.Add(student);
                ctx.SaveChanges();

                Console.WriteLine("Record saved successfully!");

            }
        }
        }
    }
}
