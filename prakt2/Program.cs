using System.Linq.Expressions;

namespace prakt2
{
    internal class Program
    {
        static void Main(string[] args)
        { int x = 0;
            do
                {
                    Console.WriteLine("1. Угадай число.");
                    Console.WriteLine("2. Таблица умножения.");
                    Console.WriteLine("3. Все делители числа.");
                    Console.WriteLine("4. Выход.");
                    Console.WriteLine("Что хотите запустить?");
                    int.TryParse(Console.ReadLine(), out x);
                    switch (x) 
                    { 
                        case 1:
                        UgadaiChislo();
                        break;
                        case 2:
                        Tabl();
                        break;
                        case 3:
                        Del();
                        break; 
                    }   
                }
            while (x<=3 && x>0);
        } 
        static bool Proverk(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }
        static void Tabl()
        {
            var tabl = new int[10, 10];
            for (int i = 1; i < 10; ++i)
            {
                for (int n = 1; n < 10; ++n)
                {
                    tabl[i, n] = i * n;
                    Console.Write(tabl[i, n] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Del()
        {
            Console.WriteLine("Введите число: ");
            int e = 0;
            int.TryParse(Console.ReadLine(), out e);
            for (int i = 1; i+1<=e; ++i)
            {
                if (e % i == 0)
                    Console.Write(i + "\t");
            }
            Console.WriteLine(e);
        }
        static void UgadaiChislo()
        {
            Random rnd = new Random();
            int b = rnd.Next(0, 100);
            Console.WriteLine("Введите число от 0 до 100");
            int a = -1;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                bool ugd = Proverk(a, b);
                if (ugd == true)
                    Console.WriteLine("Ура, победа");
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine("Больше");
                    }
                    else if (b < a)
                    {
                        Console.WriteLine("Меньше");
                    }
                }
            }
            while (a != b);
        }
    }   
}