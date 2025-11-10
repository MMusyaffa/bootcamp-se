// Write a simple console program that prints the number from 1 to n, for each number x:

// print "foo", if x is divisible by 3
// print "bar", if x is divisible by 5
// print "foobar", if x is divisible by 3 and 5

// print the number itself, if x satisfies none of the rule
// Here's a sample output of such program with n=15
// >> 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar

// Continuing on the previous question. Add the following rules
// print "jazz", if x is divisible by 7
// This means for x = 21 x = 35 and x = 105 the program should print "foojazz", "barjazz" and "foobarjazz" respectively.

namespace PracticeTask
{
    class Task2
    {
        public static void RunTask2()
        {
            int num = 0;

            Console.Write("Please enter a number: ");
            num = int.Parse(Console.ReadLine());

            DivisibleNumber2(num);
            // SimplifyDivisible(num);
        }

        public static void DivisibleNumber2(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                string output = "";
                
                if (i % 3 == 0)
                {
                    output += "foo";
                }

                if (i % 5 == 0)
                {
                    output += "bar";
                }

                if (i % 7 == 0)
                {
                    output += "jazz";
                }

                Console.Write((output == "" ? i.ToString() : output) + ", ");
            }
        }

        public static void SimplifyDivisible(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string msg = "";

                if (i % 3 == 0) { msg += "foo"; }
                if (i % 5 == 0) { msg += "bar"; }
                if (i % 7 == 0) { msg += "jazz"; }

                Console.Write((msg == "" ? i.ToString() : msg) + ", ");
            }
        }
    }
}