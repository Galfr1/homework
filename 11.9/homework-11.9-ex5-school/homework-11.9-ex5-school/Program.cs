//Made by Gal Fried

//This code is in .NET 6 and isn't compatible in older versions
//see https://aka.ms/new-console-template for more information

//printing instructions to the user
Console.WriteLine("Welcome to salery calculator!");
Console.WriteLine("Please enter the base salery:");

//initializing base salery double
double baseSalery = 5000;

try
{
    //trying to read input from the user and saving it to the varrible
    baseSalery = double.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid base salery, using the default 5000.");
}

//printing instructions to the user
Console.WriteLine("Please enter fee (for no fee, leave empty):");

//initializing fee double
double fee = 0;

try
{
    //trying to read input from the user and saving it to the varrible
    fee = double.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid fee, using no fee.");
}

//printing instructions to the user
Console.WriteLine("Please enter the amount of times you want to give fee (for no fee, leave empty):");

//initializing int for how many times to give the fee
int feeAmount = 0;

try
{
    //trying to read input from the user and saving it to the varrible
    feeAmount = int.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid number for how many times you want to give fee, using no fee");
}

//printing the result
Console.WriteLine("The total salery will be " + (baseSalery + (fee * feeAmount)) + "$");

