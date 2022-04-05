using System;

namespace CommandsWithInheritance
{
    internal class OneParameterCommand : Command
    {
        private string _question;

        public OneParameterCommand(
            Numbers numbers, char letter, string question)
            : base(numbers, letter)
        {
            _question = question;
        }

        public override void Run()
        {
            Console.Write(_question);
            var numberStr = Console.ReadLine();
            var number = Convert.ToInt32(numberStr);
            RunImpl(number);
        }

        public virtual void RunImpl(int number)
        {

        }
    }
}
