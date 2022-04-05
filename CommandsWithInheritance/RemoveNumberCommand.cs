using System;

namespace CommandsWithInheritance
{
    internal class RemoveNumberCommand : OneParameterCommand
    {
        public RemoveNumberCommand(
            Numbers numbers, char letter)
            : base(numbers, letter, "Hvilket tall vil du fjerne? ")
        {
        }

        public override void RunImpl(int number)
        {
            Numbers.Remove(number);
        }
    }
}
