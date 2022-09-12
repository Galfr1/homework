//Made by Gal Fried

//This code is in .NET 6 and may not be compatible with older versions
//see https://aka.ms/new-console-template for more information

//showing instructions to the user
Console.WriteLine("This program will show you how many days you are alive.");
Console.WriteLine("Please input your birthday (as DD/MM/YYYY):");

//reading user input
string birthday = Console.ReadLine();

//initializing DateTime varible to store the date, using now as the default
DateTime date = DateTime.Now;

try
{
    //trying to format the date to the requierd MM/DD/YYYY format
    String[] splited = birthday.Split("/");
    String formatedDate = splited[1] + "/" + splited[0] + "/" + splited[2];

    //trying to store the formatted date
    date = DateTime.Parse(formatedDate);
}
catch
{
    //if there is an eror, printing out to the user
    Console.WriteLine("You didn't enter a valid date, exiting the program - try again later.");

    //exiting the program
    Environment.Exit(0);
}

//storing the time alive
TimeSpan age = DateTime.Now.Subtract(date);

//converting the time alive to days and printing it out to the user
Console.WriteLine("You are " + age.TotalDays + " days old!");

