//Made by Gal Fried

//This code made in .NET 6 and is not compatible with previous versions
//see https://aka.ms/new-console-template for more information

//writing instructions to the user
Console.WriteLine("Welcome to the class information generator!");
Console.WriteLine("enter the amount of boys in the class:");

//initializing boys int
int boys = 10;

//trying to read user input
try
{
    //writing the user input to the boys int
    boys = int.Parse(Console.ReadLine());
}
catch
{
    //if the amount of boys is not int, using 10 as the amount and writing to the user
    Console.WriteLine("You can't have that amount of boys!\ni will make it 10...");
}

//writing instructions to the user
Console.WriteLine("enter the amount of girls in the class:");

//initializing girls int
int girls = 10;

//trying to read the user input
try
{
    //writing the user input to the girls int
    girls = int.Parse(Console.ReadLine());
}
catch
{
    //if the input is not int, using 10 as the amount and writing to the user
    Console.WriteLine("You can't have that amount of girls!\ni will make it 10...");
}

//printing out the amount of students in the class
Console.WriteLine("The amount of students in the class is: " + (boys + girls));

//checking conditions and operating accordingly
if (boys > girls)
{
    //printing to the user the result
    Console.WriteLine("The ratio of boys to girls is " + (boys / girls) + ":1");
}
else if (girls > boys)
{
    //printing to the user the result
    Console.WriteLine("The ratio of girls to boys is " + (girls / boys) + ":1");
}
else
{
    //printing to the user the result
    Console.WriteLine("The ratio of boys to girls is 1:1");
}

