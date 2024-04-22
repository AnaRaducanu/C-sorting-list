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
            // Checking if input file path is provided
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the input file path.");
                return;
            }

            // Getting the input file path from command line arguments
            string inputFile = args[0];
            Console.WriteLine(inputFile);

            // Reading unsorted names from the input file
            var unsortedExtractedList = ReadFile(inputFile);

            // Sorting the names by surname
            ISortingStrategies sorting = new SortingStrategies();
            var sortedList = sorting.SortBySurname(unsortedExtractedList);

            // Creating the output file path
            string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFile), "sorted-names-list.txt");
            Console.WriteLine(outputFilePath);
            
            // Writing the sorted names to the output file
            WriteToFile(sortedList, outputFilePath);
            
            Console.ReadLine();
        }

        // Function to read names from a file
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

        // Function to write sorted names to a file
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