//------------------------------------------------
// GetTheUsersName.cs (c) 2006 by Charles Petzold
//------------------------------------------------
using System;

class GetTheUsersName
{
    static void Main()
    {
        Console.Write("Type your name and press Enter: ");
        string strName = Console.ReadLine();
        Console.Write("Your name is ");
        Console.WriteLine(strName);
    }
}
