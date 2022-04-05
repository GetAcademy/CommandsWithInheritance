using System.Collections.Generic;
using System.Linq;

namespace CommandsWithInheritance
{
    internal class Numbers
    {
        private readonly List<int> _numbers;

        public Numbers()
        {
            this._numbers = new List<int>();
        }

        public int[] GetNumbers()
        {
            return _numbers.ToArray();
        }

        public int GetSum()
        {
            return _numbers.Sum();
        }

        public void Add(int number)
        {
            var i = 0;
            while (i < this._numbers.Count&& this._numbers[i] < number)
            {
                i++;
            }
            _numbers.Insert(i, number);
        }

        public void Remove(int number)
        {
            _numbers.Remove(number);
        }
    }
}
