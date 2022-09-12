//Made by Gal Fried

//This code is in .NET 6 and isn't compatible with older versions
//see https://aka.ms/new-console-template for more information

//printing instructions to the user
Console.WriteLine("This program will calculate stuff about cinema profit.");
Console.WriteLine("Please enter the amount of sits in the cinema:");

//initializing total seats int varrible
int seats = 10;

try
{
    //trying to read input from the user and saving it to the varrible
    seats = int.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter valid amount of seats, using the default 10.");
}

//printing instructions to the user
Console.WriteLine("Please enter the amount of seats sold in your cinema:");

//initializing sold seats int varrible
int soldSeats = 10;

try
{
    //trying to read input from the user and saving it to the varrible
    soldSeats = int.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid amount of sold seats, using the default 10.");
}

//printing instructions to the user
Console.WriteLine("Please enter the price of one seat:");

//initializing price double varrible
double price = 10.0;

try
{
    //trying to read input from the user and saving it to the varrible
    price = double.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid price, using the default 10.");
}

//printing the results to the user
Console.WriteLine("You made " + (soldSeats * price) + "$");
Console.WriteLine("You could made " + ((seats - soldSeats) * price) + "$ more.");

