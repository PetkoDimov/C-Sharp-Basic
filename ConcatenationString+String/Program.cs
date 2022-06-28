using System;

namespace ConcatenationString_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string output = "Hello " + name + "!";

            Console.WriteLine(output);

            ///string a = "1"
            ///int b = 22
            ///int c = 3
            ///console.writeline(a + b + c);
            ///tovata shte vzeme a kato tip string, i vsqko sledvashto shte mu nasledi tip string i shte gi subere kato znaci edno do drugo.
            ///ako console.writeline (b + c + a) shte smetne b + c kato chisla i do sbora shte dolepi a kato string.
          
        }
    }
}
