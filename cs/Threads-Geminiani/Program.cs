namespace Threads_A
{
    class Program
    {
        static void metodoDaEseguire1()
        {
            Console.WriteLine("Thread: " + Thread.CurrentThread.Name + " sul processore " + Thread.GetCurrentProcessorId());

            StreamWriter scrivi = new("file_main1.txt");
            
            int quanti= 1000000000;
            for (int i = 0; i < quanti; i++) scrivi.WriteLine("*");
            scrivi.Close();
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "main";
            Thread t1 = new(metodoDaEseguire1);
            t1.Name = nameof(t1);

            Console.WriteLine("Thread: " + Thread.CurrentThread.Name + " sul processore " + Thread.GetCurrentProcessorId());

            t1.Start();

            var start = DateTime.Now;

            int quanti= 1000000000;
            
            StreamWriter scrivi = new("file_main2.txt");
            for (int i = 0; i < quanti; i++) scrivi.WriteLine("+");
            scrivi.Close();

            t1.Join();

            var end = DateTime.Now;
            Console.WriteLine((end - start).TotalMilliseconds);
        }
    }
}