//Made by Gal Fried

//This code is made in .NET 6 and is not compatible with older versions
//see https://aka.ms/new-console-template for more information

//getting the current year as string from the 'System' package
string currentYearString = DateTime.Now.Year.ToString();

//converting the string to float
float currentYear = float.Parse(currentYearString);

//writing instructions for the user
Console.WriteLine("Welcome to age calculator!");
Console.WriteLine("Please enter the year you born at:");

//initializing user input year float
float userYearInput = 0;

//trying to read the user input
try
{
    //writing the user input to the float
    userYearInput = float.Parse(Console.ReadLine());
}
catch
{
    //if the user did something wrong assuming that he is Jesus by the default
    Console.WriteLine("You didn't enter a year, i will assume you are Jesus...");
}

//printing the result to the user
Console.WriteLine("You are alive " + (currentYear - userYearInput) + " years.");

