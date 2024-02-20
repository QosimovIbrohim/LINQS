namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProgrammingLanguage> __pr = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage(){Id = 1,Name = "C#"},
                new ProgrammingLanguage(){Id = 3,Name = "Angular"},
                new ProgrammingLanguage(){Id = 2,Name = "Assembly"}
            };
            List<Buxalters> buxaltersList = new List<Buxalters>
        {
            new Buxalters { BId = 1, BName = "John Smith", ProgrammingLanguageId = 1 },
            new Buxalters { BId = 2, BName = "Alice Johnson", ProgrammingLanguageId = null },
            new Buxalters { BId = 3, BName = "David Lee", ProgrammingLanguageId = 1 },
            new Buxalters { BId = 4, BName = "Emily Brown", ProgrammingLanguageId = 3 },
            new Buxalters { BId = 5, BName = "Michael Davis", ProgrammingLanguageId = 2 },
        };
            // dasturlash tilini biladigan bugalterlar

            //var s = buxaltersList.Join(__pr, bs => bs.ProgrammingLanguageId, pr => pr.Id, (Buxalters bs, ProgrammingLanguage pr) => new { BugId = bs.BId, Bna = bs.BName, BPN =pr.Name });
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item.BugId + " " + item.Bna + " " + item.BPN);
            //}



            // c# ni biladigan dasturchilar

            //var s = buxaltersList.Join(__pr, bs => bs.ProgrammingLanguageId, pr => pr.Id, (Buxalters bs, ProgrammingLanguage pr) => new { BugId = bs.BId, Bna = bs.BName, BPN = pr.Name }).Where(l => l.BPN == "C#");
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item.BugId + " " + item.Bna + " " + item.BPN);
            //}

            // qandaydir shartning qandaydir yechimi😥

            //var s = __pr.GroupJoin(buxaltersList, prg => prg.Id, bxs => bxs.ProgrammingLanguageId, ( prg,  bxs) => new { PrgName = prg.Name, Bsd = bxs });
            //foreach (var item in s)
            //{
            //    Console.Write(item.PrgName + " -> ");
            //    foreach(var item2 in item.Bsd)
            //    {
            //        Console.Write(item2.BId + " ");
            //        Console.Write(item2.BName+ " ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Buxalters
    {
        public int BId { get; set; }
        public string? BName { get; set; }
        public int? ProgrammingLanguageId { get; set; }
    }
}
