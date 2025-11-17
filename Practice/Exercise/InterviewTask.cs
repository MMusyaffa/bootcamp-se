namespace InterviewTask
{
    class InterviewQuestion
    {
        public static void Run()
        {
            Console.Write("\nPlease enter your name: ");
            string? name = Console.ReadLine();
            ShowName(name!);
            ReversedName(name!);
            SeparateName(name!);
        }

        IEnumerable<string> strings = new List<string>();

        static void ShowName(string name)
        {
            Console.WriteLine("Your name is: " + name);
        }

        static void ReversedName(string name)
        {
            string reversedName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];
            }

            Console.WriteLine("Your reverse name: " + reversedName);
        }

        static void SeparateName(string name)
        {
            string vocalName = "";
            string nonVocalName = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'i' || name[i] == 'e' || name[i] == 'u' || name[i] == 'o')
                {
                    vocalName += name[i];
                }
                else
                {
                    nonVocalName += name[i];
                }
            }

            Console.WriteLine("Vocal: " + vocalName);
            Console.WriteLine("Non Vocal: " + nonVocalName);
        }
    }
}