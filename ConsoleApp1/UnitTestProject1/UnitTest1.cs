using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
                a = re.Next(1, 100);
                b = re.Next(1, 100);
                sum = re.Next(1, 5);


                if (sum == 1)
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                else if (sum == 2)
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
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
    }
}
