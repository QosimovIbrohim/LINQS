namespace ConsoleApp1.LINA
{
    public class University
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Location { get; set; }

        public List<Student>? Students { get; set; }
    }
}