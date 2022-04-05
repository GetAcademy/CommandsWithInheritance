using System;

namespace CommandsWithInheritance
{
    internal class ShowSumCommand : Command
    {
        public ShowSumCommand(
            Numbers numbers, char letter)
            : base(numbers, letter)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Summen er:");
            Console.WriteLine(Numbers.GetSum());
        }
    }
}
