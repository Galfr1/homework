//Made by Gal Fried

//This code is in .NET 6 and isn't compatible with older versions
//see https://aka.ms/new-console-template for more information

//writing message to the user
Console.WriteLine("This program will do diffrent calculations about trains.");

//function that read doubles and print eror and instruction
static double doubleIo(String instruction, String erorMessage)
{
    //printing the instruction
    Console.WriteLine(instruction);

    try
    {
        //trying to read and return a double
        return double.Parse(Console.ReadLine());
    }
    catch
    {
        //if there is an eror, printing eror message and returning a default of 10
        Console.WriteLine(erorMessage);
        return 10;
    }
}

//function that read ints and print eror and instruction
static int intIo(String instruction, String erorMessage)
{
    //printing the instructions
    Console.WriteLine(instruction);

    try
    {
        //trying to read and return an int
        return int.Parse(Console.ReadLine());
    }
    catch
    {
        //if there is an eror, printing eror message and returning a default of 10
        Console.WriteLine(erorMessage);
        return 10;
    }
}

//reading the ints and doubles using costume messeges
int wagonsAmount = intIo("Please enter the amount of wagons:", "You didn't enter a valid amount of wagons, using the default 10.");
int locomotiveAmount = intIo("Please enter the amount of locomotives:", "You didn't enter a valid amount of locomotives, using the default 10.");
int amountOfPassengers = intIo("Please enter the amount of passengers allowed per wagon:", "You didn't enter a valid amount of allowed passengers per wagon, using the default 10.");
double wagonLength = doubleIo("Please enter the length of wagon:", "You didn't enter a valid length of wagon, using the default 10.");
double locomotiveLength = doubleIo("Please enter the length of locomotive:", "You didn't enter a valid length of locomotive, using the default 10.");

//printing the final results to the user
Console.WriteLine("The amount of people allowed to be on the train is " + (wagonsAmount * amountOfPassengers) + ".");
Console.WriteLine("The length of the train is " + ((wagonsAmount * wagonLength) + (locomotiveAmount * locomotiveLength)) + "m.");

