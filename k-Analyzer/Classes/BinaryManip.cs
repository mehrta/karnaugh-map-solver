using System;
using System.Collections.Generic;
using System.Text;

namespace K_Analyzer
{
    static class BinaryManip
    {
        public static bool GetBitValue(int value, byte bitIndex)
        {
            int tmp = value;
            tmp = tmp << (31 - bitIndex); // 16 is size of a int data type (in bit) (32-1=31 is required)
            tmp = tmp >> 31;

            return tmp == 0 ? false : true;
        }

        public static void SetBitValue(ref int value, byte bitIndex, bool newBitValue)
        {
            bool bitValue = GetBitValue(value, bitIndex);
            if (bitValue != newBitValue)
            {
                int tmp = 1;
                tmp = tmp << bitIndex;
                value = (value ^ tmp);
            }
        }

        public static string GetBinaryValue(int value, int digitsCount)
        {
            StringBuilder digits = new StringBuilder();

            for (byte i = 0; i < digitsCount; i++)
                if (GetBitValue(value, i))
                    digits.Append('1');
                else
                    digits.Append('0');

            return digits.ToString();
        }

        public static int GetDecimalValue(int[] bits)
        {
            int value = 0, weight = 1;

            foreach (int bit in bits)
            {
                value += bit * weight;
                weight *= 2;
            }

            return value;
        }

    }
}
