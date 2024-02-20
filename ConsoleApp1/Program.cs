using ConsoleApp1.LINA;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = LINQMethods.GetContractSt("PDP");
            foreach(var item in x)
            {
                Console.Write(item.FirstName +" ");
                Console.Write(item.LastName + " ");
                Console.Write(item.isContract + " ");
                Console.WriteLine(item.Age);
            }
        }
    }
}
