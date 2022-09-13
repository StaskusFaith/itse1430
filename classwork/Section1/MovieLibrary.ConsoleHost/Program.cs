// Movie Definintion
// Faith Staskus
// Start Date 8/29/22

string title = "";
string description = "";
int runLength = 0;          // in minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

DisplayInformation();
do
{
    DisplayMenu();
} while (true);
  Console.WriteLine("Movie Library");
    Console.WriteLine("ITSE 1430 Sample");
    Console.WriteLine("Fall 2022");
AddMovie();

// Functions

void DisplayInformation ()
{ 
    enum MenuOption()
    {


    }
    bool done = false;
    do
    {
        MenuOption input = DisplayMenu();
        Console.WriteLine();
        switch (MenuOption)
        {
            case 'a':
            case 'A':
            {
             case 'A': AddMovie(); break;
            }
            case 'E': EditMovie(); break;
            case 'V': ViewMovie(); break;
            case 'D': DeleteMovie(); break;
            case 'Q': done = true; break;
        };
    };
}

char DisplayMenu ()
{
    Console.WriteLine();
    Console.WriteLine("A)dd Movie");
    Console.WriteLine("E)dit Movie");
    Console.WriteLine("V)iew Movie");
    Console.WriteLine("D)elete Movie");
    Console.WriteLine("Q)uit");

    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        switch(key.Key
        {
            case ConsoleKey.A:return 'A';
            case ConsoleKey.E: return 'E';
            case ConsoleKey.V: return 'V';
            case ConsoleKey.D: return 'D';
            case ConsoleKey.Q: return 'Q';
    }while (true);

}

title = ReadString("Enter a title: ");
description = ReadString("Enter an optional description: ");
runLength = ReadInt32("Enter a run length (in minutes): ");
releaseYear = ReadInt32("Enter the release year: ");
rating = ReadString("Enter a MPAA rating: ");
Console.WriteLine("Is this a classic: ");

bool ReadBoolean ( string message)
{
    Console.Write(message);

    //Looking for y/n
    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if 

    }

}

int ReadInt32 ( string message )
{ 
    Console.Write(message);
    string value = Console.ReadLine();

    //inline variable declaration
    ////int result;
    if (Int32.TryParse(value, out int result))
        return result;

    return -1;
    
}

string ReadString ( string message )
{
    Console.Write(message);

    string value = Console.ReadLine();

    return value;

}
void AddMovie ()
{


}

void DeleteMovie ()
{
        if (title == "")
            return;

        //Not Confirmed
        if !(ReadBoolean("Are you sure you want to delete the movie (Y/N)? "))
            return;

        title = " ";

void EditMovie ()
{


}

void ViewMovie ()
{
        if (title == "")
        {
            Console.WriteLine("No movies available");
            return;

        };

    Console.WriteLine(title);
    Console.WriteLine(releaseYear);
    Console.WriteLine("Length: " + runLength+ " mins");
    Console.WriteLine("MPPA Rating: " + rating);
    Console.WriteLine("Classic " + isClassic);
    Console.WriteLine(description)
}