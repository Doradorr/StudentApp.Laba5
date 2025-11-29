using System;
using System.Collections.Generic;
using StudentApp.BLL;
using StudentApp.DAL;

namespace StudentApp.PL
{
    internal class Program
    {
        static void Main()
        {
            var repo = new StudentRepository();

            var students = new List<Student>
            {
                new Student { FirstName="Іван", LastName="Коваль", Height=180, Weight=70, StudentCard="AA111", PassportSN="KA123456" },
                new Student { FirstName="Марія", LastName="Шевченко", Height=165, Weight=55, StudentCard="BB222", PassportSN="KA654321" },
                new Student { FirstName="Олег", LastName="Лисенко", Height=172, Weight=80, StudentCard="CC333", PassportSN="KA987654" }
            };

            repo.Save(students);

            var service = new StudentService(repo);

            var ideal = service.GetIdealWeightStudents();

            Console.WriteLine("\nСтуденти з ідеальною вагою:");

            foreach (var s in ideal)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName} — {s.Height}см, {s.Weight}кг");
            }

            Console.WriteLine("\nПеревірка онлайн навчання:");
            var internet = new InternetService { IsInternetAvailable = true };
            Console.WriteLine(internet.LearnOnline());
        }
    }
}
