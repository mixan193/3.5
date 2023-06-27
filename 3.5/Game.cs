using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    internal class Game
    {
        private int number;
        private Random random;
        public Game(int number)
        {
            random = new Random();
            this.number = random.Next(number);
        }
        public int ChekNumber(int num)
        {
            if (num > number)
            {
                return 1;
            }
            else if (num < number)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public int GetNumber()
        {
            return number;
        }
    }
}
