using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int  random()
            {
                Random re = new Random();
                re.Next();
                return re.Next(1,100);
            }
            void text()
            {
                Random re = new Random();
                re.Next();
                int i;
                int temp = 0;
                int sum;
                int a, b;
                Console.WriteLine("请输入需要生成的四则运算的数量");
                i = int.Parse(Console.ReadLine());
                for (; temp < i; temp++)
                {
                    a = random();
                    b = random();
                    sum = re.Next(1, 5);


                    if (sum == 1)
                        Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    else if (sum == 2)
                    {
                        if (a > b)
                            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                        else
                            Console.WriteLine("{0}-{1}={2}", b, a, b - a);

                    }
                    else if (sum == 3)
                        Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    else if (sum == 4)
                    {
                        a = re.Next(1, 10);
                        b = re.Next(1, 10);
                        Console.WriteLine("{0}/{1}={2}", a * b, a, (a * b) / a);
                    }

                }
            }
            text();
        }
    }
}
