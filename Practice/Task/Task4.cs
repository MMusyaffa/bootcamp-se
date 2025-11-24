/*
Write a simple console program that prints the number from 1 to n, for each number x:

print "foo", if x is divisible by 3
print "bar", if x is divisible by 5
print "foobar", if x is divisible by 3 and 5

print the number itself, if x satisfies none of the rule
Here's a sample output of such program with n=15
>> 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14,foobar

Continuing on the previous question. Add the following rules
print "jazz", if x is divisible by 7
This means for x = 21 x = 35 and x = 105 the program should print "foojazz", "barjazz" and "foobarjazz" respectively.

Continuing on the previous question. Using the same divisible logic, use the table below as the rules  3: "foo"  4: "baz"  5: "bar"  7: "jazz"  9: "huzz"

Turn the generator logic in the code you have so far into a class object and make it so that the client code can configure its own rules i.e. add the following API
myClass.AddRule(int input, string output)
*/

namespace PracticeTask
{
    class Task4
    {
        int number = 0;

        public void RunTask()
        {
            Console.Write("Please enter a number: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out number);
        }

        public void AddRule(int input, string output)
        {
            DivisibleNumber4(number, input, output);
        }

        public void DivisibleNumber4(int num, int numInput, string output)
        {
            for (int i = 1; i <= num; i++)
            {
                string message = "";

                if (i % 3 == 0) { message += "foo"; }
                if (i % 4 == 0) { message += "baz"; }
                if (i % 5 == 0) { message += "bar"; }
                if (i % 7 == 0) { message += "jazz"; }
                if (i % 9 == 0) { message += "huzz"; }
                if (i % numInput == 0) { message += output; }

                Console.Write((message == "" ? i.ToString() : message) + ", ");
            }
        }
    }
}