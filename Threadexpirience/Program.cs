internal class Program
{
    private static void Main(string[] args)
    {
        Thread myThread = new Thread(Print);
        // запускаем поток myThread
        myThread.Start();

        // действия, выполняемые в главном потоке
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Главный поток: + {i}");
            Thread.Sleep(300);
        }

        // действия, выполняемые во втором потокке
        void Print()
        {
            string a = "agda";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Второй поток: {i} {a}");
                Thread.Sleep(400);
            }
        }
    }
}