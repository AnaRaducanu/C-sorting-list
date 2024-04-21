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
