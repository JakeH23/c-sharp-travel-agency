# c-sharp-travel-agency
A console application for interacting with travel agency data.

## Tasks

### 1. Set up your solution, create some classes

* Create a new .NET 5.0 solution with a Console Application project (your main project) and an xUnit test project
* Create `Hotel`, `Customer` and `Employee` classes - structure these classes around the data in the JSON files
* You'll notice some repetition between the the `Customer` and `Employee` classes - can you DRY it up a bit?
* Write constructors for your classes that allow you to set some initial values, write unit tests to check the constructors behave as you'd expect

### 2. Interact with the console

* Create another class - `ConsoleService` - that reads a user’s name from the console and prints a custom greeting message (https://docs.microsoft.com/en-us/dotnet/api/system.console?view=net-5.0)
* Don't worry about unit testing the output of the console (`Console` is not a class you've written), just verify it's working by reading the output

### 3. Load your JSON data

* Create an `Agency` class with two properties - `Employees` (a list of employees) and `Hotels` (a list of hotels)
* When the constructor for the `Agency` class is invoked, these lists should be populated with the data from the JSON files. This will require you to read the files (https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-5.0) and deserialize them from JSON (https://www.newtonsoft.com/json)
* Write unit tests to ensure that the data you expect is being loaded into the `Agency` class
* [OPTIONAL] Aim to have one underlying method that is responsible for reading both the employees and hotels JSON files
* [OPTIONAL] separate all JSON-loading functionality into a separate class, then use an instance of that class to load your data

### 4. Print your data to the console

* Go back to the `ConsoleService` class you created in step 2. After the user has been greeted, list two options to the user (“A - Read Hotels”, “B - Read Employees”)

* Expand the `ConsoleService` functionality to print the Name and Id of each Hotel if the user selects A.
* Expand the `ConsoleService` functionality to print the Name and Id of each Employee if the user selects B.
* Don't worry about unit testing the output of the console (`Console` is not a class you've written), just verify it's working by reading the output
{"mode":"full","isActive":false}
