using System;
using System.Collections.Generic;

namespace ReverseStringWithStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> input = new Stack<char>(Console.ReadLine());
            foreach (char c in input)
            {
                Console.Write(c);
            }
        }
    }
}
