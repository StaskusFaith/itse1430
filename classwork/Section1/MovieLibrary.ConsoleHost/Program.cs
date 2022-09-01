// Movie Definintion
// Faith Staskus
// Start Date 8/29/22

string title = "";
string description = "";
int runLength = 0;          // in minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;


title = ReadString("Enter a title: ");
description = ReadString("Enter an optional description: ");
runLength = ReadInt32("Enter a run length (in minutes): ");
releaseYear = ReadInt32("Enter the release year: ");
rating = ReadString("Enter a MPAA rating: ");
Console.WriteLine("Is this a classic: ");

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


