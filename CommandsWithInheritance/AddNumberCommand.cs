using System;

namespace CommandsWithInheritance
{
    internal class AddNumberCommand : OneParameterCommand
    {
        public AddNumberCommand(
            Numbers numbers, char letter)
            : base(numbers, letter, "Hvilket tall vil du legge til? ")
        {
        }

        public override void RunImpl(int number)
        {
            Numbers.Add(number);
        }
    }
}
