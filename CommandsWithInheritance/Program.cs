using System;
using System.Linq;

namespace CommandsWithInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Numbers();
            var commands = new Command[]
            {
                new ShowNumbersCommand(numbers, 'V'),
                new AddNumberCommand(numbers, 'L'),
                new ShowSumCommand(numbers, 'S'),
                new RemoveNumberCommand(numbers, 'F'),
            };
            while (true)
            {
                Console.WriteLine("Meny: V=vis, S=sum, L=legg til, F=fjern");
                Console.Write("Hva vil du gjøre? ");
                var commandLetter = Console.ReadLine()[0];
                var cmd = commands.FirstOrDefault(c => c.Letter == commandLetter);
                if (cmd == null) continue;
                cmd.Run();
            }

            /*
            while (true)
            {
                Console.WriteLine("Meny: V=vis, S=sum, L=legg til, F=fjern");
                Console.Write("Hva vil du gjøre? ");
                var command = Console.ReadLine();
                if (command == "V")
                {
                    var cmd = new ShowNumbersCommand(numbers);
                    cmd.Run();
                }
                else if (command == "L")
                {
                    var cmd = new AddNumberCommand(numbers);
                    cmd.Run();
                }
            }             
             */
        }
    }
}
