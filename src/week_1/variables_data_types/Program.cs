// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int variable1 = 1;
uint variable1_1 = 1;
string variable2 = "Some string";
double variable3 = 0.3f;
float variables3_1 = 0.4f;
char variable4 = 'C';
bool variable5 = true;


int asVariable3 = (int)variable3;
//0
double asVariable3_3 = (double)asVariable3;
//0
Console.WriteLine(asVariable3_3);


int diameter = 15;
double piNumber = Math.PI;
Console.WriteLine($"Pi number is {piNumber}");
double area = piNumber * diameter * diameter;
Console.WriteLine($"The area of circle is:{area}");

double modusExample = 106 % 3;
Console.WriteLine($"The modus is :{modusExample}");


bool commited = true;
bool inTransit = false;

if(commited || inTransit)
{
    Console.WriteLine($"This is OR result");
}

if (commited && inTransit)
{
    Console.WriteLine($"This is AND result");
}

int aValue = 4;
int bValue = 3;

bool resultIsBigger = aValue > bValue;
bool resultIsTheSame = aValue == bValue;
bool resultIsTheSameOrBigger = aValue >= bValue;

Console.WriteLine($"resultIsBigger :{resultIsBigger}");
Console.WriteLine($"resultIsTheSame :{resultIsTheSame}");
Console.WriteLine($"resultIsTheSameOrBigger :{resultIsTheSameOrBigger}");

resultIsBigger = false;

const int constantValue = 1;
//constantValue = 2; WONT DEBUGGED

int priorityValue = 2 + 3 * 4;
int priorityValue2 = (2 + 3) * 4;
int priorityValue3 = 2 + (3 * 4);
int autoChangedValue = priorityValue++; // priorityValue +1
int autoChangedValue2 = priorityValue--;
int autoChangedValue3 = ++priorityValue;
int autoChangedValue4 = --priorityValue;

Console.WriteLine($"priorityValue :{priorityValue}");
Console.WriteLine($"priorityValue :{priorityValue2}");
Console.WriteLine($"priorityValue :{priorityValue3}");
Console.WriteLine($"autoChangedValue :{autoChangedValue}");
Console.WriteLine($"autoChangedValue :{autoChangedValue2}");
Console.WriteLine($"autoChangedValue :{autoChangedValue3}");
Console.WriteLine($"autoChangedValue :{autoChangedValue4}");

var result = Console.ReadLine();

Console.WriteLine(result);