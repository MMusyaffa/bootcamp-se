// Write a simple console program that prints the number from 1 to n, for each number x:

// print "foo", if x is divisible by 3
// print "bar", if x is divisible by 5
// print "foobar", if x is divisible by 3 and 5

// print the number itself, if x satisfies none of the rule
// Here's a sample output of such program with n=15
// >> 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14,foobar

// Answear

namespace PracticeTask
{
    class Task1
    {
        public static void RunTask1()
        {
            int num = 0;

            Console.Write("Please enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            DivisibleNumber(num);
        }

        static void DivisibleNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FooBar, ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Foo, ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Bar, ");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}