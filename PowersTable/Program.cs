// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learn your squares and cubes!");

int integer = 0;

do
{
    int squared = integer;
    int cubed = integer;
   
    Console.WriteLine("Please enter an integer: ");
    integer = int.Parse(Console.ReadLine());

    if(integer <= 0)
    {
        Console.WriteLine("Invalid Input");
    }
    else if (integer > 5000)
    {
        Console.WriteLine("Please choose a number less than 1000");
        break;
    }

    Console.WriteLine("Number  Squared  Cubed");
    Console.WriteLine("======  =======  ======");

    {
        squared = integer * integer;
        cubed = integer * integer * integer;
        Console.WriteLine("  {0}        {1}       {2}  ", integer, squared, cubed);
    }

    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            continue;
        }
        else if (choice == "n")
        {
            break;
        }
    }
    
} 

while (true);