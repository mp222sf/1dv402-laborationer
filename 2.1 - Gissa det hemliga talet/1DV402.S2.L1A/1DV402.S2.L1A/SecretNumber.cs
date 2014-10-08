using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;
        
        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
            _count = 0;
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
        }

        public bool MakeGuess(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(
                    "Talet är inte i intervallet mellan 1-100.");
            }

            if (_count == 7)
            {
                throw new ApplicationException(
                    "Endast 7 kast är tillåtna.");
            }

            if (number == _number)
            {
                _count++;
                Console.WriteLine("Gratulerar! Rätt gissat. Du klarade det på {0} försök.", _count);
                return true;
            }
            else if (number > _number)
            {
                _count++;
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, 7-_count);
                if (_count == 7)
                {
                    Console.WriteLine("Det hemliga talet är {0}.", _number);
                }
                return false;
            }
            else if (number < _number)
            {
                _count++;
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, 7-_count);
                if (_count == 7)
                {
                    Console.WriteLine("Det hemliga talet är {0}.", _number);
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
