using NameSortingAlgorithm;
using NameSortingAlgorithm.Interfaces;
using NameSortingAlgorithm.Interfaces.Implementation;
using System;
using System.Collections.Generic;
using System.IO;

namespace NameSortingAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the input file path.");
                return;
            }
                // Specifying the file path
                string inputFile = args[0];
            
               var unsortedExtractedList = ReadFile(inputFile);

            // Create an instance of SortingStrategies
            ISortingStrategies sorting = new SortingStrategies();
            var sortedList = sorting.SortBySurname(unsortedExtractedList);

            // Write the sorted list to a new text file
                string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFile), "sorted-names-list.txt");
                WriteToFile(sortedList, outputFilePath);
                Console.ReadLine();
        }
        
        // Method for inputFile
        public static List<string> ReadFile(string inputFile)
        {
            List<string> unsortedExtractedList = new List<string>();

            using (StreamReader sr = new StreamReader(inputFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    unsortedExtractedList.Add(line.Trim());
                }
            }
            return unsortedExtractedList;
        }

        // Method for WriteToFile
        public static void WriteToFile(List<string> sortedList, string outputFilePath)
        {
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                foreach (string name in sortedList)
                {
                    sw.WriteLine(name);
                    Console.WriteLine(name);
                }
            }
        }
    }
}