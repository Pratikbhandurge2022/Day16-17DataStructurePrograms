using System;
using System.Collections.Generic;


namespace DataStructurePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Programs!");

            string inputFilePath = @"D:\BridgeLabz\Day16-17.1\DataStructurePrograms\InputFile.txt";
            string outputFilePath = @"D:\BridgeLabz\Day16-17.1\DataStructurePrograms\OutputFile.txt";
            string equationFilePath = @"D:\BridgeLabz\Day16-17.1\DataStructurePrograms\Equation.txt";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Select and enter program number:" +
                    "(1. Unordered List, 2. Ordered List, 3. Balanced Parentheses");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        new UnOrderedList().UnorderListOperations(inputFilePath, outputFilePath);
                        break;
                    case 2:
                        new OrderedList().OrderedListOperations(inputFilePath, outputFilePath);
                        break;
                    case 3:
                        new BalancedParentheses().isBalancedParentheses(equationFilePath);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}