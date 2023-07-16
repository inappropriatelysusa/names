using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var names = new string[] { "John", "Sally", "Bob", "Alice", "Zelda" };

        var sortedNames = from name in names
                          where name.Length < 5
                          orderby name
                          select name;

        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}
