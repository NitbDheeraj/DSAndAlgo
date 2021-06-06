using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    public class BloomFilter<T>
    {
        private BitArray _bits = new BitArray(32);

        private Int16 FirstHashFunction(string input)
        {
            Int16 returnValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                returnValue += (Int16)((int)input[i]);
                returnValue = (Int16)(returnValue % 32);
            }

            return returnValue;
        }

        private Int16 SecondHashFunction(string input)
        {
            Int16 returnValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                returnValue += (Int16)((int)input[i] * i);
                returnValue = (Int16)(returnValue % 32);
            }

            return returnValue;
        }

        public void AddString(string input)
        {
            Int16 firstBit = FirstHashFunction(input);
            Int16 secondBit = SecondHashFunction(input);
            this._bits[firstBit] = true;
            this._bits[secondBit] = true;
        }

        public bool Contains(string input)
        {
            Int16 firstBit = FirstHashFunction(input);
            Int16 secondBit = SecondHashFunction(input);

            if (this._bits[firstBit] && this._bits[secondBit])
                return true;
            else
                return false;
        }

    }
}
