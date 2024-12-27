using System;
using System.Collections.Generic;

namespace Operations.Csharp
{
    internal class Program
    {
        static int calcOperations(List<string> operations)
        {
            int result = 0;

            foreach (string operation in operations)
            {
                if (operation == "++")
                    result++;
                else
                    result--;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of operations: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<string> operations = new List<string>();

            Console.WriteLine("Enter '++' or '--' only.");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter the {i} operation: ");
                string op = Console.ReadLine();

                if (op == "++" || op == "--")
                    operations.Add(op);
                else
                {
                    Console.WriteLine("Invalid operation, Try another.");
                    n++;
                }
            }

            Console.WriteLine($"\nThe number after these operations = {calcOperations(operations)}");
        }
    }
}
