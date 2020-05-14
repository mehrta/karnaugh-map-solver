using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using K_Analyzer.Types;

namespace K_Analyzer
{
    public class CMinterm
    {
        // Fields
        int m_mintermIndex = 0;
        bool m_boolValue = false;

        // Properties
        public bool BoolValue
        {
            set
            {
                m_boolValue = value;
            }
            get
            {
                return m_boolValue;
            }
        }

        // Methods
        public CMinterm() { }

        public CMinterm(int mintermIndex)
        {
            SetIndex(mintermIndex);
        }

        public void SetIndex(int index)
        {
            m_mintermIndex = index;
        }

        public int GetDecimalIndex()
        {
            return m_mintermIndex;
        }

        public void SetBitValue(byte bitIndex, bool newBitValue)
        {
            BinaryManip.SetBitValue(ref m_mintermIndex, bitIndex, newBitValue);
        }

        public bool GetBitValue(byte bitIndex)
        {
            return BinaryManip.GetBitValue(m_mintermIndex, bitIndex);
        }

        public string GetBinaryIndex(EKarnaughTableType tableType)
        {
            int digitsCount;

            if (tableType == EKarnaughTableType.Karnaugh3Var)
                digitsCount = 3;
            else
                digitsCount = 4;

            return BinaryManip.GetBinaryValue(m_mintermIndex,digitsCount);
        }

    }
}
