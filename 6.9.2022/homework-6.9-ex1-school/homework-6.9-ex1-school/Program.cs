//Made by Gal Fried

//This code made in .NET 6 and is not compatible with older versions
//see https://aka.ms/new-console-template for more information

//writing instructions for the user
Console.WriteLine("Welcome to the rectangle wizard!");
Console.WriteLine("Plese enter length in number form (default is 10):");

//initializing length float
float length = 10;

//trying to read the input of the user
try
{
    //writing the input inside the length float
    length = float.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, using the default and telling the user
    Console.WriteLine("You shold have entered a number!\nusing the default for now...");
}

//writing instructions for the user
Console.WriteLine("Plese enter width in number form (default is 10):");

//initializing width float
float width = 10;

//trying to read the user input
try
{
    //writing the user input to the width float
    width = float.Parse(Console.ReadLine());
}
catch
{
    //if there is an eror, using the default and telling the user
    Console.WriteLine("You shold have entered a number!\nusing the default for now...");
}

//prfloating the results to the user
Console.WriteLine("The area of the rectangle is: " + (length * width));
Console.WriteLine("The extent of the rectangle is: " + ((length*2)+(width*2)));

