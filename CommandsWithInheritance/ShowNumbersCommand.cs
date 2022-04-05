using System;

namespace CommandsWithInheritance
{
    internal class ShowNumbersCommand : Command
    {
        public ShowNumbersCommand(
            Numbers numbers, char letter)
        : base(numbers, letter)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Tallener er:");
            Console.WriteLine(
                string.Join(",", Numbers.GetNumbers()));
        }
    }
}
