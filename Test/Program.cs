using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var gradeId = AddGrade(new Grade()
            //{
            //    GradeName = "B",
            //    Section = "Uni",                
            //});


            //UpdateGrid(new Grade()
            //{
            //    Id = 2,
            //    GradeName = "B",
            //    Section = "Uniiiiiii",
            //});

            //var grade = GetGrade(1);

            // var grades = AllGrades();


            //var grade = GetGrade(1);
            //DeleteGrade(grade);
        }


        static int AddGrade(Grade grade)
        {
            using (var context = new SchoolContext())
            {
                context.Grades.Add(grade);
                context.SaveChanges();
                return grade.Id;
            }
        }

        static void UpdateGrid(Grade grade)
        {
            using (var context = new SchoolContext())
            {
                context.Grades.Update(grade);
                context.SaveChanges();
            }
        }

        static void DeleteGrade(Grade grade)
        {
            using (var context = new SchoolContext())
            {
                context.Grades.Remove(grade);
                context.SaveChanges();
            }
        }

        static Grade GetGrade(int id)
        {
            using (var context = new SchoolContext())
            {
                return context.Grades.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        static List<Grade> AllGrades()
        {
            using (var context = new SchoolContext())
            {
                return context.Grades.ToList();
            }
        }
    }
}








