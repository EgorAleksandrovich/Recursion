using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    public class Recursion
    {
        public static int recursion1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            Console.WriteLine(n);
            return recursion1(n - 1) * n;
        }

        public static string recursion2(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            return recursion2(n - 1) + ", " + n;
        }

        public static string recursion3(int a, int b)
        {
            if (b == a)
            {
                return b.ToString();
            }
            if (a > b)
            {
                return recursion3(a, b + 1) + ", " + b;
            }
            else
            {
                return recursion3(a, b - 1) + ", " + b;
            }
        }

        public static string recursion4(int a)
        {
            if (a == 1)
            {
                return "YES";
            }
            if (a % 2 != 0)
            {
                return "NOT";
            }
            return recursion4(a / 2);
        }

        public static int recursion5(int a)
        {
            if (a < 10)
            {
                return a;
            }
            return recursion5(a / 10) + a % 10;
        }

        public static string recursion6(int a, int b)
        {
            if (b == a || a == 2 || b == 1)
            {
                return "YES";
            }
            if (a % b == 0 )
            {
                return "NO";
            }
            return recursion6(a, b - 1);
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Task 1\n");
            Console.WriteLine(recursion1(5));
            Console.WriteLine("\n");

            Console.WriteLine("Task 2\n");
            Console.WriteLine(recursion2(5));
            Console.WriteLine("\n");

            Console.WriteLine("Task 3\n");
            Console.WriteLine(recursion3(11, 6));
            Console.WriteLine("\n");

            Console.WriteLine("Task 4\n");
            Console.WriteLine(recursion4(6));
            Console.WriteLine("\n");

            Console.WriteLine("Task 5\n");
            Console.WriteLine(recursion5(6615));
            Console.WriteLine("\n");

            Console.WriteLine("Task 5\n");
            int a = 4;
            Console.WriteLine(recursion6(a, 2));
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
