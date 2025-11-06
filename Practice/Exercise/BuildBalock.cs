namespace BalockExercise
{
    class BalockTask
    {
        public static void Run()
        {
            int sum = 5;
            Star(sum);
        }

        static void Star(int star)
        {
            for (int i = 1; i <= star; i++)
            {
                Console.WriteLine(new string('*', i));
            }

            for (int i = star; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }

            for (int i = 0; i < star; i++)
            {
                Console.Write(new string(' ', i));
                Console.WriteLine(new string('*', (star - i)));
            }

            for (int i = star - 1; i >= 0; i--)
            {
                Console.Write(new string(' ', i));
                Console.WriteLine(new string('*', (star - i)));
            }
        }
        
        static void Chess(int chess)
        {
            for (int i = 1; i < chess; i++)
            {
                
            }
        }
    }
}