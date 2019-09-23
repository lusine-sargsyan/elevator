using System;

namespace lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("======lift=====");
            Console.Write("Where you are heading? ");

            a = Int32.Parse(Console.ReadLine());

            b = 1;

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(3000);
            }
            Console.Beep();
            b = a;
            Console.Write("On which floor are you now? ");
            a = Int32.Parse(Console.ReadLine());
            if (b > a)
            {
                for (int i = b; i >= a; i--)

                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(3000);
                }



                Console.Beep();
                b = a;

            }
            else
            {
                for (int i = b; i <= a; i++)

                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(3000);
                }

                Console.Beep();
                b = a;
            }
            Console.Write("Where you are heading? ");
            a = Int32.Parse(Console.ReadLine());
            if (b > a)
            {
                for (int i = b; i >= a; i--)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(3000);
                }
                Console.Beep();
                b = a;
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(3000);
                }
                Console.Beep();
                b = a;
            }
        }
    }
}
