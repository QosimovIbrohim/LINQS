namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ss/*IEnumerable<int> numbers = Nums();

            // Using Skip to skip the first 5 elements and then Take the next 4 elements
            //IEnumerable<int> skippedAndTakenNumbers = numbers.Skip(3).Take(4);





            // Output the taken elements after skipping
            /*foreach (int number in skippedAndTakenNumbers)
            {
                Console.WriteLine(number);
            }*//*
            IEnumerable<Deps> stringList = new List<Deps>();
            stringList.ToList().ForEach(str => {Console.WriteLine(str.id);});*/
            #endregion


            /*List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 18, GroupId = 1 },
            new Student { Id = 2, Name = "Bob", Age = 19, GroupId = 2 },
            new Student { Id = 3, Name = "Charlie", Age = 20, GroupId = 3 },
            new Student { Id = 4, Name = "David", Age = 21, GroupId = 4 },
            new Student { Id = 5, Name = "Emma", Age = 22, GroupId = 5 },
            new Student { Id = 6, Name = "Frank", Age = 23, GroupId = 1 },
            new Student { Id = 7, Name = "Grace", Age = 24, GroupId = 2 },
            new Student { Id = 8, Name = "Henry", Age = 25, GroupId = 3 },
            new Student { Id = 9, Name = "Ivy", Age = 26, GroupId = 4 },
            new Student { Id = 10, Name = "Jack", Age = 27, GroupId = 5 },
            new Student { Id = 11, Name = "Kate", Age = 28, GroupId = 1 },
            new Student { Id = 12, Name = "Leo", Age = 29, GroupId = 2 },
            new Student { Id = 13, Name = "Mia", Age = 30, GroupId = 3 },
            new Student { Id = 14, Name = "Nathan", Age = 31, GroupId = 4 },
            new Student { Id = 15, Name = "Olivia", Age = 32, GroupId = 5 },
            new Student { Id = 16, Name = "Peter", Age = 33, GroupId = 1 },
            new Student { Id = 17, Name = "Queenie", Age = 34, GroupId = 2 },
            new Student { Id = 18, Name = "Robert", Age = 35, GroupId = 3 },
            new Student { Id = 19, Name = "Sarah", Age = 36, GroupId = 4 },
            new Student { Id = 20, Name = "Tom", Age = 37, GroupId = 5 }
        };

            var x = students.Select(o => o).Where(s => s.Id > 3 && s.Id < 7);
            foreach (var s in x)
            {
                Student.PrintStudent(s);
            }*/

            List<ProgrammingLanguage> __pr = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage(){Id = 1,Name = "C#"},
                new ProgrammingLanguage(){Id = 1,Name = "Angular"},
                new ProgrammingLanguage(){Id = 1,Name = "Assembly"}
            };
            List<Buxalters> buxaltersList = new List<Buxalters>
        {
            new Buxalters { BId = 1, BName = "John Smith", ProgrammingLanguageId = 1 },
            new Buxalters { BId = 2, BName = "Alice Johnson", ProgrammingLanguageId = null },
            new Buxalters { BId = 3, BName = "David Lee", ProgrammingLanguageId = 1 },
            new Buxalters { BId = 4, BName = "Emily Brown", ProgrammingLanguageId = 3 },
            new Buxalters { BId = 5, BName = "Michael Davis", ProgrammingLanguageId = 2 },
        };

            var s = buxaltersList.Join(__pr, bs => bs.BId , pr => pr.Id ,(Buxalters bs,ProgrammingLanguage pr) => new {BugId = bs.BId ,Bna = bs.BName, })
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        public static void PrintStudent(Student st)
        {
            Console.Write("Id:" + st.Id + " Name: ");
            Console.Write(st.Name + "Age: ");
            Console.Write(st.Age + " GRid: ");
            Console.WriteLine(st.GroupId);
        }

    }

    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Buxalters
    {
        public int BId { get; set; }
        public string BName { get; set; }
        public int? ProgrammingLanguageId { get; set; }

        public static void PrintBuxalters(Buxalters bx)
        {
            Console.WriteLine($"Id : {bx.Id} \nName: {bx.BName}\nPr_Id: {bx.ProgrammingLanguageId}\n");
        }

    }
}
