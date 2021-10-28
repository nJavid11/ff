using System;

namespace LastTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Numbers of spaces: " + task11(s));
        }

        #region task11
        public static int task11(string s)
        {
            int count = 0;
            foreach (char ch in s)
            {
                if (ch.Equals(' '))
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
    }
}
