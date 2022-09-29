using static System.Console;
var startingbackg = Console.BackgroundColor;

//While Loop
while (true)
{
    Clear();
    Write("Choose a number between 10 and 99 ");
    string? number = ReadLine();

    if (number == "exit" || number == "Exit" || number == "End" || number == "end")
    {
        Write("THANK YOU FOR PLAYING");
        break;
    }

    int number1 = Convert.ToInt32(number);
    if (number1 % 23 == 0)
    {
        BackgroundColor = ConsoleColor.Green;
    }
    else if (number1 >= 10 && number1 <= 100)
    {
        BackgroundColor = ConsoleColor.Red;
    }
    else if (number1 <= 9)
    {
        WriteLine("WHAT ARE YOU DOING?");
        break;
    }
    else
    {
        WriteLine("WHAT ARE YOU DOING?");
        break;
    }
}


// //Do While Loop
BackgroundColor = startingbackg;
int orange1;
do
{
    Clear();
    WriteLine("Start of do/while loop");
    Write("Enter a number between 10 and 99 ");
    string? orange = ReadLine();
    if (orange == "exit" || orange == "Exit" || orange == "End" || orange == "end")
    {
        Write("THANK YOU FOR PLAYING");
        break;
    }


    orange1 = Convert.ToInt32(orange);
    if (orange1 == 34 && orange1 == 68)
    {
        BackgroundColor = ConsoleColor.Green;
    }
    else if (orange1 >= 10 && orange1 <= 99)
    {
        BackgroundColor = ConsoleColor.Red;
    }
    if (orange1 >= 99)
    {
        Write("WHAT ARE YOU DOING?");
        break;
    }
    else
    {
        Write("WHAT ARE YOU DOING?");
        break;
    }
}
while (true);