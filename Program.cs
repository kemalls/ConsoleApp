using System;
string cities = "Mumbai Indians\nDelhi Capitals\nRajsthan Royals";

int count = 1;

for (int i = 0; i < cities.Length; i++)
{
    if (cities[i] == '\n')
        count++;
}

Console.WriteLine("Lines:");
Console.WriteLine(cities);
Console.WriteLine("Total lines in a string: " + count);
Console.WriteLine("Press any key to continue...");
Console.ReadKey();


