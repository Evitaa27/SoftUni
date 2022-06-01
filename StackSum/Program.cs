using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> forSum = new Stack<int>(input);
            string[] commands = Console.ReadLine().ToLower().Split(' ');
            
            while (commands[0] != "end")
            {
                if (commands[0] == "add")
                {
                    forSum.Push(int.Parse(commands[1]));
                    forSum.Push(int.Parse(commands[2]));
                }
                else if (commands[0] == "remove")
                {
                    if (int.Parse(commands[1]) < forSum.Count)
                    {
                        for (int i = 0; i < int.Parse(commands[1]); i++)
                        {
                            forSum.Pop();
                        }
                    }
                }
                commands = Console.ReadLine().ToLower().Split(' ');
            }
            Console.WriteLine($"Sum: {forSum.Sum()}");
        }
    }
}
