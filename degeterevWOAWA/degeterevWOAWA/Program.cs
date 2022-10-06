namespace degeterevWOAWA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
            while (q < 1)
            {
                Console.WriteLine("Выберите одну из трех программ:\n" +
                    "1-Угадай число\n" +
                    "2-Таблица Умножения\n" +
                    "3-Закончить работу программы");
                int nomer = Convert.ToInt32(Console.ReadLine());
                if (nomer == 1)
                {
                    Random();
                }
                if (nomer == 2)
                {
                    Umnozh();
                }
                if (nomer == 3)
                {
                    break;
                }
            }
        }
        static void Random()
        {
            Random rand = new Random();
            int a = rand.Next(0, 100);
            Console.WriteLine("Ваша задача угадать число то 0 до 100.");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != a)
            {
                Console.WriteLine("Вы проиграли, так как не угадали число.Попробуйте снова.");
                
                b = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("Поздравляю, вы угадали число.");        
        }
        static void Umnozh()
        {
            double[,] tablica = new double[10, 10];
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    Console.Write("{0}\t", i * j);
            Console.WriteLine();
        }
  
    }
}