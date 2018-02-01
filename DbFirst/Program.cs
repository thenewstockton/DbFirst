using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
            }

            var authorCourses = dbContext.GetAuthorCourses(1);

            var course = new Course();
            //course.Level = CourseLevel.Beginner;

            Console.ReadKey();
        }
    }


}
