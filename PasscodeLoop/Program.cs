using System;

namespace PasscodeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            const string pass = "Password";
            string attempt;

            int n = 0;
            do
            {
                Console.Write("Please enter password: ");
                attempt = Console.ReadLine();

                if (attempt == pass)
                {
                    Console.WriteLine("Access granted.");
                    break;
                }
                else
                {
                    Console.WriteLine("Access denied.");
                    n++;
                }
            } while (n <= 3);
            */

            //2nd password loop
            const string pass = "Password";
            int attempt = 0;

            string attempt1;
            do
            {
                Console.Write("Please enter password: ");
                attempt1 = Console.ReadLine();

                if (attempt1 == pass)
                {
                    Console.WriteLine("Access granted.");
                }
                else
                {
                    Console.WriteLine("Access denied.");
                    attempt++;
                }
            } while (attempt <= 3 && attempt1 != pass);
        }
    }
}
