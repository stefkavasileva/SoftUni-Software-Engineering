using System;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem
{
    public class Startup
    {
        public static void Main()
        {
            using (var db = new StudentSystemContext())
            {
                db.Database.EnsureCreated();
                InitialSeed(db);
            }
        }

        private static void InitialSeed(StudentSystemContext db)
        {
            SeedStudents(db);
            SeedCourses(db);
            SeedResources(db);
        }

        private static void SeedResources(StudentSystemContext db)
        {
            var randomName = new string[] { "Defining classes", "Data types", "OOP", "Objects", "Queries" };

            for (int i = 0; i < randomName.Length; i++)
            {
                db.Resources.Add(new Resource{ Name = randomName[i]});
            }

            db.SaveChanges();
        }

        private static void SeedCourses(StudentSystemContext db)
        {
            var randomName = new string[] { "C#", "Ruby", "Java", "JS", "DbBasic" };
            for (int i = 0; i < randomName.Length; i++)
            {
                db.Courses.Add(new Course { Name = randomName[i] });
            }

            db.SaveChanges();
        }

        private static void SeedStudents(StudentSystemContext db)
        {
            var randomName = new string[] { "Ingomar", "Roxy", "Roksana", "Kenith", "Cheri " };
            for (int i = 0; i < randomName.Length; i++)
            {
                db.Students.Add(new Student { Name = randomName[i] });
            }

            db.SaveChanges();
        }
    }
}
