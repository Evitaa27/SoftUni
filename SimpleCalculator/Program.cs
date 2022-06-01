using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] reversedInput = input.Reverse().ToArray();
            Stack<string> expression = new Stack<string>();
            for (int i = 0; i < reversedInput.Length; i++)
            {
                expression.Push(reversedInput[i]);
            }
            int sum = int.Parse(expression.Pop());
            while (expression.Count > 0)
            {
                string operators = expression.Pop();
                int currentNum = int.Parse(expression.Pop());
                if (operators == "+")
                {
                    sum += currentNum;
                }
                else if (operators == "-")
                {
                    sum -= currentNum;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
