// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your age: ");
string input = Console.ReadLine();

int age = Convert.ToInt32(input);

age += 1; // age = age + 1; or age++;

string output = age.ToString();

Console.WriteLine("Next year you will be " + output + " years old");
Console.WriteLine($"Next year you will be {output}  years old");
Console.WriteLine(string.Format("Next year you will be {0}  years old", output));

Console.ReadKey();