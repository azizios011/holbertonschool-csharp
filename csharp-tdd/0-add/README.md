### README for Test Library

#### Setup Instructions:
1. **Clone Repository**: Clone the repository containing the class library and test library projects.

   ```bash
   git clone <repository_url>
   ```

2. **Navigate to Test Library Directory**: Move to the directory of the test library associated with the specific task. For example, if the task is "0-add", navigate to the "MyMath.Tests" directory.

   ```bash
   cd 0-add/MyMath.Tests
   ```

3. **Install NUnit (if not already installed)**: If NUnit is not installed, use the command:

   ```bash
   dotnet new -i NUnit3.DotNetNew.Template
   ```

4. **Add Reference to Class Library**: To add your class library as a dependency to the test project, run the following command:

   ```bash
   dotnet add reference ../MyMath/MyMath.csproj
   ```

   This command establishes a reference from the test library to the class library.

5. **Run Tests**: Execute the tests by running the command:

   ```bash
   dotnet test
   ```

   This command will run all tests within the test library and provide detailed feedback on test results.

#### Contribution Guidelines:
- Contributions to enhance test coverage or improve test quality are welcome.
- Ensure that any changes or additions to tests adhere to established coding standards and practices.
- Before submitting a pull request, ensure that all existing tests pass and any new functionality is thoroughly tested.

#### Reporting Issues:
- Report any issues, bugs, or suggestions related to the test library by creating a new issue in the repository's issue tracker.
- Provide detailed information about the problem encountered, including steps to reproduce and expected behavior.

''''

### README for Class Library

#### Setup Instructions:
1. **Clone Repository**: Clone the repository containing the class library and test library projects.

   ```bash
   git clone <repository_url>
   ```

2. **Navigate to Class Library Directory**: Move to the directory of the class library associated with the specific task. For example, if the task is "0-add", navigate to the "MyMath" directory.

   ```bash
   cd 0-add/MyMath
   ```

3. **Build the Project**: Build the project by running the command:

   ```bash
   dotnet build
   ```

   This command compiles the source code and generates the necessary binaries.

4. **Add Reference to Class Library (in Console Application)**: If you'd like to use your class library methods in a console application, create a new directory for your console application, navigate into it, and run the following command:

   ```bash
   dotnet new console
   ```

5. **Add Reference to Class Library**: After creating the console application, add a reference to your class library by running the command:

   ```bash
   dotnet add reference ../MyMath/MyMath.csproj
   ```

   This command establishes a reference from the console application to the class library.

6. **Run the Console Application**: You can now call your class library methods inside the console application. To run the console application, use the command:

   ```bash
   dotnet run
   ```

#### Usage:
- The class library can be referenced and utilized in other C# projects by adding a reference to the generated DLL file or by including the project in the solution.
- Ensure that proper documentation is consulted to understand the available methods, their parameters, and return types.

#### Contribution Guidelines:
- Contributions to enhance existing functionalities or add new features are welcome.
- Follow established coding standards and best practices when making changes to the class library.
- Thoroughly test any modifications to ensure they do not introduce regressions or unexpected behavior.

#### Reporting Issues:
- Report any issues, bugs, or suggestions related to the class library by creating a new issue in the repository's issue tracker.
- Provide detailed information about the problem encountered, including steps to reproduce and expected behavior.
