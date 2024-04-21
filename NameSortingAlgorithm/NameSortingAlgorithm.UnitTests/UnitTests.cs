using NameSortingAlgorithm.Interfaces.Implementation;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace NameSortingAlgorithm.UnitTests
{
    public class UnitTests
    {
        // This test method checks if the SortBySurname method in the SortingStrategies class correctly sorts a list of names by surname and then by any given names.
        [Fact]
        public void SortBySurname_UnsortedNames_ReturnsSortedNames()
        {
            // Arrange
            var sortingStrategies = new SortingStrategies();
            var unsortedList = new List<string> { "Alice Smith", "Bob Johnson", "Alice Johnson" };
            var expectedSortedList = new List<string> { "Alice Johnson", "Bob Johnson", "Alice Smith" };

            // Act
            var sortedList = sortingStrategies.SortBySurname(unsortedList);

            // Assert
            sortedList.ShouldNotBeNull();
            sortedList.ShouldBe(expectedSortedList);
        }

        // This test method verifies that the ReadFile method in the Program class correctly reads the content of a file.
        [Fact]
        public void ReadFile_ShouldReadFileContent()
        {
            // Arrange
            string inputFile = "inputTestFile.txt"; // Provide a sample input file
            List<string> expectedList = new List<string> { "Bob", "Alice", "Charlie" }; // Define expected content

            // Act
            List<string> result = Program.ReadFile(inputFile);

            // Assert
            result.ShouldBe(expectedList);
        }

        //This test method validates the WriteToFile method in the Program class by ensuring that it writes a list of names to a file correctly.
        [Fact]
        public void WriteToFile_ShouldWriteToFile()
        {
            // Arrange
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" }; // Sample list of names
            string outputFilePath = "OutputTestFile.txt"; // Define output file path

            // Act
            Program.WriteToFile(names, outputFilePath);

            // Assert
            File.ReadAllLines(outputFilePath).ShouldBe(names);
        }
    }
}
