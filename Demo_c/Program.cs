using System;

namespace Demo_c
{
    class Program
    {
        static void Main(string[] args)
        {
            //use of foreach loop
            Char[] myArray = { 'h', 'e', 'l', 'l', 'o' };
            foreach(Char ch in myArray)
            {
                Console.WriteLine(ch);
            }


        }
    }
}
