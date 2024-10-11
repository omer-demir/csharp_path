# C# Guide: Setting Up and Creating Your First Console Project

## 1. Installing the .NET SDK

The **.NET SDK** (Software Development Kit) is necessary to develop C# applications. Follow the steps below to install it.

### Steps to Install .NET SDK

1. Go to the official [.NET SDK Download Page](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).
2. Select **.NET 7.0** (or the latest stable version) and download the appropriate installer for **Windows**.
3. Run the installer and follow the instructions to complete the installation.
4. Verify the installation by opening **Command Prompt** or **PowerShell** and typing:

    ```bash
    dotnet --version
    ```

   This will show the installed .NET version.

## 2. Installing Visual Studio Code

**Visual Studio Code (VS Code)** is a lightweight, powerful code editor that is widely used for C# development.

### Steps to Install Visual Studio Code

1. Download **Visual Studio Code** from the official [Visual Studio Code Website](https://code.visualstudio.com/).
2. Run the installer and follow the instructions to complete the installation.

## 3. Installing Required Extensions in Visual Studio Code

To develop C# applications in Visual Studio Code, you need to install some useful extensions.

### Extensions to Install

1. **C# for Visual Studio Code** (by Microsoft): This provides support for editing and debugging C# code.
2. **.NET Install Tool for Extension Authors** (by Microsoft): Helps ensure the .NET SDK is correctly installed.
3. **Debugger for .NET (Core CLR)** (optional, but helps in debugging .NET applications).

### How to Install Extensions

1. Open **Visual Studio Code**.
2. Click on the **Extensions** icon in the Activity Bar on the side of the window (or press `Ctrl+Shift+X`).
3. Search for "C#" and install the **C# for Visual Studio Code** extension by Microsoft.
4. Similarly, search for the **.NET Install Tool for Extension Authors** and install it.
5. Optionally, search and install **Debugger for .NET (Core CLR)** for better debugging features.

## 4. Creating Your First C# Console Project

Now that your environment is set up, let's create and run a simple C# console project.

### Steps to Create a C# Console Project:

1. Open **Command Prompt** or **PowerShell** and navigate to the folder where you want to create your project.
2. Run the following command to create a new console application:

    ```bash
        dotnet new console -n MyFirstApp
    ```

   This command creates a new folder called `MyFirstApp` containing the necessary files for a C# console project.

3. Navigate into the newly created project folder:

   ```bash
   cd MyFirstApp
   ```

4. Open the project in **Visual Studio Code**:

   ```bash
   code .
   ```

5. The main file you'll work with is `Program.cs`. By default, it contains a simple C# program that looks like this:

   ```csharp
   // Program.cs
   Console.WriteLine("Hello, World!");
   ```

### Steps to Run the Console Project:

1. In **Visual Studio Code**, open the **Terminal** (you can open it by pressing ``Ctrl+` ``).
2. In the terminal, run the following command:

   ```bash
   dotnet run
   ```

3. You should see the output:

   ```
   Hello, World!
   ```

Congrats! You’ve just created and run your first C# program!

## 5. Summary of Commands

- To create a new console project:

  ```bash
  dotnet new console -n MyFirstApp
  ```

- To navigate into the project folder:
  
  ```bash
  cd MyFirstApp
  ```

- To run the project:
  
  ```bash
  dotnet run
  ```

## 6. Additional Resources

- Official **.NET SDK Documentation**: [Microsoft .NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- **Visual Studio Code Documentation**: [VS Code Documentation](https://code.visualstudio.com/docs)
