namespace CommandsWithInheritance
{
    internal class Command
    {
        public char Letter { get; }
        protected Numbers Numbers { get; }

        public Command(Numbers numbers, char letter)
        {
            Letter = letter;
            Numbers = numbers;
        }

        public virtual void Run()
        {
        }
    }
}
