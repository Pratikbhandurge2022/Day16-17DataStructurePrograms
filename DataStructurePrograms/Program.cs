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
            new UnOrderedList().UnorderListOperations(inputFilePath, outputFilePath);
        }
    }
}