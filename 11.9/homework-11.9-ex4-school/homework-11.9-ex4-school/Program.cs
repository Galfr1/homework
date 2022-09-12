//Made by Gal Fried

//This code is in .NET 6 and isn't compatible with older versions
//see https://aka.ms/new-console-template for more information

//printing instructions to the user
Console.WriteLine("This program will calculate stuff about swiming.");
Console.WriteLine("Please enter the length of the pool in meters:");

//initializing pool length double
double poolLength = 100;

try
{
    //trying to read input from the user and saving it to the varrible
    poolLength = double.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid length, using the default 100.");
}

//printing instructions to the user
Console.WriteLine("Enter how many pools you swim per workout:");

//initializing double for the amount of pools
double pools = 100;

try
{
    //trying to read input to the user and saving it to the varrible
    pools = double.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid amount of pools, using the default 100.");
}

//printing instructions to the user
Console.WriteLine("Enter how many workouts you do per month:");

//initializing amount of workouts int
int workouts = 10;

try
{
    //trying to read input from the user and saving it to the varrible
    workouts = int.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid amount of workouts, using the default 10.");
}

//printing the result
Console.WriteLine("You swim " + (workouts * pools * poolLength) + "m per month.");

