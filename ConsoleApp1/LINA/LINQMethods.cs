using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LINA
{
    internal class LINQMethods
    {
        public static List<University> GetAll()
        {
            List<University> list = new List<University>()
            {
                new University { Id = 1, Name = "PDP", Location = "Sergili", Students  =
                new List<Student>() {
                    new Student() { Id = 1, Age = 27, isContract = true, FirstName = "Akramjon", LastName = "Abduvahobov" },
                    new Student() { Id = 2, Age = 20, isContract = false, FirstName = "Abduxoliq", LastName = "Abduxoliqov" },
                    new Student() { Id = 3, Age = 23, isContract = false, FirstName = "Muhammad Abdulloh", LastName = "Muhammad Abdullohov" },
                    new Student() { Id = 4, Age = 40, isContract = true, FirstName = "Ikromjon", LastName = "Ikromjon" },
                } },
                new University { Id = 2, Name = "IT Park", Location = "Yashnobod", Students  =
                new List<Student>() {
                    new Student() { Id = 1, Age = 30, isContract = true, FirstName = "Xoliqjon", LastName = "Qodirov" },
                    new Student() { Id = 2, Age = 17, isContract = false, FirstName = "Javohir", LastName = "Jumaboyev" },
                    new Student() { Id = 3, Age = 20, isContract = true, FirstName = "Jasur", LastName = "Aliyev" },
                    new Student() { Id = 4, Age = 31, isContract = false, FirstName = "Nazarbek", LastName = "Sodiqov" },
                } },

            };
            return list;
        }

        public static IEnumerable<Student> GetContractSt(string name)
        {
            /*IEnumerable<Student>? s = GetAll()
                .Where(s => s.Name == name)
                .SelectMany(o => o.Students!)
                .Where(x => x.isContract == true);
            return s.ToList();*/
            List<List<List<string>>> s = new List<List<List<string>>>();
            var x = s.SelectMany(c => c).SelectMany(i=> i).SelectMany(l=> l);

            foreach (Student i in x)
            {
                Console.WriteLine(i.FirstName);
                Console.WriteLine(i.LastName);
                Console.WriteLine(i.Age);
            }

            return x;
        }
    }
}