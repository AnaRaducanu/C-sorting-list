# Name Sorter Documentation
## Overview
The Name Sorter project is a program designed to sort a list of names first by last name and then by any given names the person may have. 
The program reads a list of names from a file, sorts them accordingly, and outputs the sorted list to the screen as well as to a file named sorted-names-list.txt.
 
## Documentation
The project structure consists of the following key components:
1. **NameSortingAlgorithm:** Contains the _sorting algorithm implementation_(ISortingStrategies.cs, SortingStrategies.cs), _name-sorter.bat script file_, _Program.cs_, _sorted-names-list.txt_ and _unsorted-names-list.txt._
2. **NameSortingAlgorithm.UnitTests:** Containing the file with unit tests _UnitTests.cs_, _inputTestFile.txt_ and _OutputTestFile.txt_

## Installation and Usage
1. Clone the repository from https://github.com/AnaRaducanu/C-sorting-list to your computer. The application is written in C# and requires an installation of Microsoft Visual Studio Code or equivalent to run.
2. Navigate to the project directory.
3. Open the NameSortingAlgorithm.sln with Visual Studio
4. Ensure you have the necessary dependencies installed.
5. The application is based on a command line user interface. In the CLI, please make sure you are into the project directory NameSortingAlgorithm where the "name-sorter.bat" script is located.
6. To use the Name Sorter program, execute the following command: **name-sorter ./unsorted-names-list.txt.** This command will sort the names from the unsorted-names-list.txt file and display the sorted list on the screen. 

## Output
The program will display the sorted list of names on the screen and write the sorted names to a file named **sorted-names-list.txt** in the working directory.

## Testing
Testing has been implemented using **xunit** and **Shouldly**.
In Visual Studio go to the tab Test and press Run All Tests. A Test Explorer Tab will open with the test details summary. 3 tests have been implementing, testing the following:
1. SortBySurname_UnsortedNames_ReturnsSortedNames:
  - This test method checks if the SortBySurname method in the SortingStrategies class correctly sorts a list of names by surname.
  - It arranges an unsorted list of names, defines the expected sorted list, and then calls the sorting method.
  - The assertion checks if the sorted list is not null and matches the expected sorted list.
    
2. ReadFile_ShouldReadFileContent:
  - This test method verifies that the ReadFile method in the Program class correctly reads the content of a file.
  - It sets up a sample input file and the expected content to be read from the file.
  - The test calls the ReadFile method and checks if the content matches the expected list.
    
3. WriteToFile_ShouldWriteToFile:
  - This test method validates the WriteToFile method in the Program class by ensuring that it writes a list of names to a file correctly.
  - It prepares a sample list of names, specifies the output file path, and then writes the names to the file.
  - The assertion reads the content of the output file and checks if it matches the list of names written.

## Travis CI Build Pipeline
1. Sign up to https://www.travis-ci.com/ using you github account
2. Inside the repository, make sure you have the **.travis.yml** file with the following information:
 language: csharp
 dotnet: 5.0
 script:
  - dotnet build NameSortingAlgorithm/NameSortingAlgorithm.sln
  - dotnet test NameSortingAlgorithm/NameSortingAlgorithm.UnitTests/NameSortingAlgorithm.UnitTests.csproj
4. That’s it! Without providing any more information, Travis CI will execute a simple pipeline that:
 - Compiles our source code
 - Executes our tests
 - Once we commit the .travis.yml file Travis will kick off our first build. Any further commits to master branch will trigger additional builds. The dashboard also allows us to manually trigger the pipeline at any time without requiring a commit or pull request.

## Contributing
Contributions to the Name Sorter project are welcome. To contribute, follow these guidelines:
1. Fork the repository.
2. Make your changes.
3. Submit a pull request with a detailed description of your changes.


## Final thoughts
While starting to work on this project, I faced a couple of challenges and this is how I overcome them:
- I wasn't familiar with testing packages for C# at all. After a detailed research on the internet, watching some youtube tutorials and asking a friend working in the industry, I decided to go with xunit and Shouldly. I followed the syntax based on the tutorials I watched.
- It took me a while to decide on how the logic will be split across files, understanding interfaces and implementing the solution based on them. By studying the principles of interfaces and their role in defining contracts for classes, I was able to establish a clear structure for sorting strategies. The ISortingStrategies interface provided a standard method signature for sorting names, enabling flexibility and consistency in strategy implementations.

An interesting and challenging project that helped me understand better C# code and syntax and how to write tests using xunit and Shouldly.

