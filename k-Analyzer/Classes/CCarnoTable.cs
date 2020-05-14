using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using K_Analyzer.Types;

namespace K_Analyzer
{
    public class CCarnoTable
    {
        // Fields
        private CMinterm[] m_minterms; // Points to minterms of a table from derived classes
        private char[] m_tableLetters;
        private ECarnoTableType m_tableType;

        #region Methods

        public CCarnoTable(ECarnoTableType tableType)
        {
            int mintermsCount = -1;

            m_tableType = tableType;

            switch (tableType)
            {
                case ECarnoTableType.Carno3Var:
                    mintermsCount = 8;
                    m_tableLetters = new char[3] { 'A', 'B', 'C' };
                    break;

                case ECarnoTableType.Carno4Var:
                    mintermsCount = 16;
                    m_tableLetters = new char[4] { 'A', 'B', 'C', 'D' };
                    break;
            }

            // Create minterms of table
            m_minterms = new CMinterm[mintermsCount];
            for (int i = 0; i < mintermsCount; i++)
            {
                m_minterms[i] = new CMinterm();
                m_minterms[i].SetIndex(i);
            }
        }

        public string GetMinimizedFunctionString()
        {
            SCarnoGroup[] functionGroups = GetFunctionGroups();
            string groupStr, functionStr = "";

            // Return string for functions with value 0 (false)
            if (functionGroups.Length == 0)
                return "0 (False)";

            foreach (SCarnoGroup group in functionGroups)
            {
                groupStr = GetGroupString(group);
                functionStr += groupStr + " + ";
            }
            functionStr = functionStr.Remove(functionStr.LastIndexOf("+"));

            return functionStr;
        }
        
        public SCarnoGroup[] GetFunctionGroups()
        {
            int functionMintermsCount = m_minterms.GetLength(0);
            bool[] functionMintermsValues = new bool[functionMintermsCount];
            bool[] coveredMinterms = new bool[functionMintermsCount];
            SCarnoGroup group = new SCarnoGroup();
            ArrayList functionGroups = new ArrayList();
            int RowsCount;


            // Map function minterms to a boolean array 
            for (int i = 0; i < functionMintermsCount; i++)
                functionMintermsValues[i] = m_minterms[i].BoolValue ? true : false;
            // - - -

            #region Search for "RectGroup_16" group
            if (functionMintermsCount == 16)
            {
                group.Type = EGroupTypes.RectGroup_16;
                group.Location = 0;

                if (IsGroupAvilableInFunctionMinterms(group))
                {
                    functionGroups.Add(group);
                    return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                }

            }
            #endregion

            RowsCount = m_tableType == ECarnoTableType.Carno3Var ? 1 : 4;

            #region Search for "RectGroup_8_Hor" groups
            group.Type = EGroupTypes.RectGroup_8_Hor;
            for (int i = 0; i < RowsCount; i++)
            {
                group.Location = i * 4;
                if (IsGroupAvilableInFunctionMinterms(group))
                {
                    if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                    {
                        InsertGroupMintermsToArray(group, coveredMinterms);
                        functionGroups.Add(group);
                    }
                    if (IsContentEqual(functionMintermsValues, coveredMinterms))
                        return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                }
            }
            #endregion

            #region Search for "RectGroup_8_Ver" groups
            if (functionMintermsCount == 16)
            {
                group.Type = EGroupTypes.RectGroup_8_Ver;
                for (int i = 0; i <= 3; i++)
                {
                    group.Location = i;
                    if (IsGroupAvilableInFunctionMinterms(group))
                    {
                        if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                        {
                            InsertGroupMintermsToArray(group, coveredMinterms);
                            functionGroups.Add(group);
                        }
                        if (IsContentEqual(functionMintermsValues, coveredMinterms))
                            return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                    }
                }

            }
            #endregion

            RowsCount = m_tableType == ECarnoTableType.Carno3Var ? 2 : 4;

            #region Search for "LinerGroup_4_Hor" groups
            group.Type = EGroupTypes.LinerGroup_4_Hor;
            for (int i = 0; i < RowsCount; i++)
            {
                group.Location = i * 4;
                if (IsGroupAvilableInFunctionMinterms(group))
                {
                    if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                    {
                        InsertGroupMintermsToArray(group, coveredMinterms);
                        functionGroups.Add(group);
                    }
                    if (IsContentEqual(functionMintermsValues, coveredMinterms))
                        return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                }
            }
            #endregion

            #region Search for "LinerGroup_4_Ver" groups
            if (functionMintermsCount == 16)
            {
                group.Type = EGroupTypes.LinerGroup_4_Ver;
                for (int i = 0; i <= 3; i++)
                {
                    group.Location = i;
                    if (IsGroupAvilableInFunctionMinterms(group))
                    {
                        if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                        {
                            InsertGroupMintermsToArray(group, coveredMinterms);
                            functionGroups.Add(group);
                        }
                        if (IsContentEqual(functionMintermsValues, coveredMinterms))
                            return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                    }
                }

            }
            #endregion

            RowsCount = m_tableType == ECarnoTableType.Carno3Var ? 1 : 4;

            #region Search for "RectGroup_4" groups
            group.Type = EGroupTypes.RectGroup_4;
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    group.Location = i * 4 + j;
                    if (IsGroupAvilableInFunctionMinterms(group))
                    {
                        if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                        {
                            InsertGroupMintermsToArray(group, coveredMinterms);
                            functionGroups.Add(group);
                        }
                        if (IsContentEqual(functionMintermsValues, coveredMinterms))
                            return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                    }
                }
            }
            #endregion

            RowsCount = m_tableType == ECarnoTableType.Carno3Var ? 2 : 4;

            #region Search for "LinerGroup_2_Hor" groups
            group.Type = EGroupTypes.LinerGroup_2_Hor;
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    group.Location = i * 4 + j;
                    if (IsGroupAvilableInFunctionMinterms(group))
                    {
                        if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                        {
                            InsertGroupMintermsToArray(group, coveredMinterms);
                            functionGroups.Add(group);
                        }
                        if (IsContentEqual(functionMintermsValues, coveredMinterms))
                            return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                    }
                }
            }

            #endregion

            RowsCount = m_tableType == ECarnoTableType.Carno3Var ? 1 : 4;

            #region Search for "LinerGroup_2_Ver" groups
            group.Type = EGroupTypes.LinerGroup_2_Ver;
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    group.Location = i * 4 + j;
                    if (IsGroupAvilableInFunctionMinterms(group))
                    {
                        if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                        {
                            InsertGroupMintermsToArray(group, coveredMinterms);
                            functionGroups.Add(group);
                        }
                        if (IsContentEqual(functionMintermsValues, coveredMinterms))
                            return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                    }
                }
            }
            #endregion

            RowsCount = m_tableType == ECarnoTableType.Carno3Var ? 2 : 4;

            #region Search for "SingleMinterm" groups
            group.Type = EGroupTypes.SingleMinterm;
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    group.Location = i * 4 + j;
                    if (IsGroupAvilableInFunctionMinterms(group))
                    {
                        if (!IsGroupMintermsAvilableInArray(group, coveredMinterms))
                        {
                            InsertGroupMintermsToArray(group, coveredMinterms);
                            functionGroups.Add(group);
                        }
                        if (IsContentEqual(functionMintermsValues, coveredMinterms))
                            return (SCarnoGroup[])functionGroups.ToArray(typeof(SCarnoGroup));
                    }
                }
            }
            #endregion

            return new SCarnoGroup[0];
        }

        public void SetFunctionByMinterms(int[] mintermIndexes)
        {
            int mintermsCount = m_minterms.GetLength(0);
            int indexesCount = mintermIndexes.GetLength(0);

            SetAllMintermsValues(false);
            for (int i = 0; i <indexesCount ; i++)
            {
                if (mintermIndexes[i] >= 0 && mintermIndexes[i] < mintermsCount)
                    m_minterms[mintermIndexes[i]].BoolValue = true;
            }
        }

        public void SetFunctionByMaxterms(int[] maxtermIndexes)
        {
            int mintermsCount = m_minterms.GetLength(0);
            int indexesCount = maxtermIndexes.GetLength(0);

            SetAllMintermsValues(true);
            for (int i = 0; i <indexesCount ; i++)
            {
                if (maxtermIndexes[i] >= 0 && maxtermIndexes[i] < mintermsCount)
                    m_minterms[maxtermIndexes[i]].BoolValue = false;
            }
        }

        public bool GetMintermValue(int mintermIndex)
        {
            return m_minterms[mintermIndex].BoolValue;
        }

        public static int[] GetMintermsIndexes(CMinterm[] minterms)
        {
            int mintermsCount = minterms.GetLength(0);
            int[] indexes = new int[mintermsCount];

            for (int i = 0; i < mintermsCount; i++)
                indexes[i] = minterms[i].GetDecimalIndex();

            return indexes;
        }

        public void SetAllMintermsValues(bool value)
        {
            foreach (CMinterm obj in m_minterms)
                obj.BoolValue = value;
        }

        public static string GetGroupString(SCarnoGroup group, char[] letters)
        {
            ArrayList groupChars = new ArrayList();
            int[] mintermIndexes = GetMintermsIndexes(GetMintermsInsideGroup(group));
            int firstMintermIndex = mintermIndexes[0];
            int indexesCount = mintermIndexes.GetLength(0);
            int equalityResult = firstMintermIndex;
            byte lettersCount = (byte)letters.GetLength(0);
            bool flag;

            // Group string for group RectGroup_16
            if ((group.Type == EGroupTypes.RectGroup_16 && lettersCount==4) || (group.Type== EGroupTypes.RectGroup_8_Hor&&lettersCount==3) )
                return "1 (True)";
            // Find bits in minterms that are equal (bits with same height)  
            for (byte i = 0; i < lettersCount; i++)
            {
                flag = true;
                for (int j = 1; j < indexesCount; j++)
                {
                    if (BinaryManip.GetBitValue(firstMintermIndex, i)
                        != BinaryManip.GetBitValue(mintermIndexes[j], i))
                    {
                        flag = false;
                        break;
                    }
                }
                BinaryManip.SetBitValue(ref equalityResult, i, flag);
            }
            // - - -

            // Produce group string
            for (byte i = 0; i < lettersCount; i++)
            {
                if (BinaryManip.GetBitValue(equalityResult, i))
                {
                    string tmpStr;
                    if (BinaryManip.GetBitValue(firstMintermIndex, i))
                        tmpStr = letters[lettersCount - i - 1].ToString();
                    else
                        tmpStr = letters[lettersCount - i - 1].ToString() + "\'";

                    groupChars.Add(tmpStr);
                }
            }
            groupChars.Reverse();
            // - - -

            // Return all strings
            string[] str = (string[])groupChars.ToArray(typeof(string));
            return string.Concat(str);
        }

        public static string GetMintermString(int mintermIndex, char[] letters)
        {
            SCarnoGroup group = new SCarnoGroup();
            group.Type = EGroupTypes.SingleMinterm;
            group.Location = mintermIndex;

            return GetGroupString(group, letters);
        }

        public ECarnoTableType GetTableType()
        {
            return m_tableType;
        }

        public static CMinterm[] GetMintermsInsideGroup(SCarnoGroup group)
        {
            CMinterm[] neighbors = new CMinterm[0];
            int[] mintermIndexes = new int[0];

            switch (group.Type)
            {
                case EGroupTypes.RectGroup_16:
                    #region RectGroup_16
                    neighbors = new CMinterm[16];
                    for (int i = 0; i < 16; i++)
                        neighbors[i] = new CMinterm(i);

                    break;
                    #endregion

                case EGroupTypes.RectGroup_8_Hor:
                    #region RectGroup_8_Hor
                    neighbors = new CMinterm[8];
                    for (int i = 0; i < 8; i++)
                        neighbors[i] = new CMinterm();

                    if (group.Location >= 0 && group.Location <= 3)
                        mintermIndexes = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 }; // Array of minterm indexes
                    else if (group.Location >= 4 && group.Location <= 7)
                        mintermIndexes = new int[8] { 4, 5, 6, 7, 12, 13, 14, 15 }; // Array of minterm indexes
                    else if (group.Location >= 8 && group.Location <= 11)
                        mintermIndexes = new int[8] { 8, 9, 10, 11, 0, 1, 2, 3 }; // Array of minterm indexes
                    else if (group.Location >= 12 && group.Location <= 15)
                        mintermIndexes = new int[8] { 12, 13, 14, 15, 8, 9, 10, 11 }; // Array of minterm indexes

                    for (int i = 0; i < 8; i++)
                        neighbors[i].SetIndex(mintermIndexes[i]);

                    break;
                    #endregion

                case EGroupTypes.RectGroup_8_Ver:
                    #region RectGroup_8_Ver
                    neighbors = new CMinterm[8];
                    for (int i = 0; i < 8; i++)
                        neighbors[i] = new CMinterm();

                    switch (group.Location % 4)
                    {
                        case 0:
                            mintermIndexes = new int[8] { 0, 4, 12, 8, 1, 5, 13, 9 }; // Array of minterm indexes
                            break;
                        case 1:
                            mintermIndexes = new int[8] { 1, 5, 13, 9, 3, 7, 15, 11 }; // Array of minterm indexes
                            break;
                        case 2:
                            mintermIndexes = new int[8] { 2, 6, 14, 10, 0, 4, 12, 8 }; // Array of minterm indexes
                            break;
                        case 3:
                            mintermIndexes = new int[8] { 3, 7, 15, 11, 2, 6, 14, 10 }; // Array of minterm indexes
                            break;
                    }

                    for (int i = 0; i < 8; i++)
                        neighbors[i].SetIndex(mintermIndexes[i]);

                    break;
                    #endregion

                case EGroupTypes.RectGroup_4:
                    #region RectGroup_4

                    neighbors = new CMinterm[4];
                    for (int i = 0; i < 4; i++)
                        neighbors[i] = new CMinterm();

                    switch (group.Location)
                    {
                        case 0:
                            mintermIndexes = new int[4] { 0, 1, 4, 5 }; // Array of minterm indexes
                            break;
                        case 1:
                            mintermIndexes = new int[4] { 1, 3, 5, 7 }; // Array of minterm indexes
                            break;
                        case 2:
                            mintermIndexes = new int[4] { 2, 0, 4, 6 }; // Array of minterm indexes
                            break;
                        case 3:
                            mintermIndexes = new int[4] { 3, 2, 7, 6 }; // Array of minterm indexes
                            break;
                        case 4:
                            mintermIndexes = new int[4] { 4, 5, 12, 13 }; // Array of minterm indexes
                            break;
                        case 5:
                            mintermIndexes = new int[4] { 5, 7, 13, 15 }; // Array of minterm indexes
                            break;
                        case 6:
                            mintermIndexes = new int[4] { 6, 4, 12, 14 }; // Array of minterm indexes
                            break;
                        case 7:
                            mintermIndexes = new int[4] { 7, 6, 15, 14 }; // Array of minterm indexes
                            break;
                        case 8:
                            mintermIndexes = new int[4] { 8, 9, 0, 1 }; // Array of minterm indexes
                            break;
                        case 9:
                            mintermIndexes = new int[4] { 9, 11, 1, 3 }; // Array of minterm indexes
                            break;
                        case 10:
                            mintermIndexes = new int[4] { 10, 8, 0, 2 }; // Array of minterm indexes
                            break;
                        case 11:
                            mintermIndexes = new int[4] { 11, 10, 3, 2 }; // Array of minterm indexes
                            break;
                        case 12:
                            mintermIndexes = new int[4] { 12, 13, 8, 9 }; // Array of minterm indexes
                            break;
                        case 13:
                            mintermIndexes = new int[4] { 13, 15, 9, 11 }; // Array of minterm indexes
                            break;
                        case 14:
                            mintermIndexes = new int[4] { 14, 12, 8, 10 }; // Array of minterm indexes
                            break;
                        case 15:
                            mintermIndexes = new int[4] { 15, 14, 11, 10 }; // Array of minterm indexes
                            break;
                    }

                    for (int i = 0; i < 4; i++)
                        neighbors[i].SetIndex(mintermIndexes[i]);

                    break;
                    #endregion

                case EGroupTypes.LinerGroup_4_Hor:
                    #region LinerGroup_4_Hor
                    neighbors = new CMinterm[4];
                    for (int i = 0; i < 4; i++)
                        neighbors[i] = new CMinterm();

                    if (group.Location >= 0 && group.Location <= 3)
                        mintermIndexes = new int[4] { 0, 1, 2, 3 }; // Array of minterm indexes
                    else if (group.Location >= 4 && group.Location <= 7)
                        mintermIndexes = new int[4] { 4, 5, 6, 7 }; // Array of minterm indexes
                    else if (group.Location >= 8 && group.Location <= 11)
                        mintermIndexes = new int[4] { 8, 9, 10, 11 }; // Array of minterm indexes
                    else if (group.Location >= 12 && group.Location <= 15)
                        mintermIndexes = new int[4] { 12, 13, 14, 15 }; // Array of minterm indexes

                    for (int i = 0; i < 4; i++)
                        neighbors[i].SetIndex(mintermIndexes[i]);

                    break;
                    #endregion

                case EGroupTypes.LinerGroup_4_Ver:
                    #region LinerGroup_4_Ver
                    neighbors = new CMinterm[4];
                    for (int i = 0; i < 4; i++)
                        neighbors[i] = new CMinterm();

                    switch (group.Location % 4)
                    {
                        case 0:
                            mintermIndexes = new int[4] { 0, 4, 12, 8 }; // Array of minterm indexes
                            break;
                        case 1:
                            mintermIndexes = new int[4] { 1, 5, 13, 9 }; // Array of minterm indexes
                            break;
                        case 2:
                            mintermIndexes = new int[4] { 2, 6, 14, 10 }; // Array of minterm indexes
                            break;
                        case 3:
                            mintermIndexes = new int[4] { 3, 7, 15, 11 }; // Array of minterm indexes
                            break;
                    }

                    for (int i = 0; i < 4; i++)
                        neighbors[i].SetIndex(mintermIndexes[i]);

                    break;
                    #endregion

                case EGroupTypes.LinerGroup_2_Hor:
                    #region LinerGroup_2_Hor
                    neighbors = new CMinterm[2];
                    for (int i = 0; i < 2; i++)
                        neighbors[i] = new CMinterm();

                    switch (group.Location % 4)
                    {
                        case 0:
                            neighbors[0].SetIndex(group.Location);
                            neighbors[1].SetIndex(group.Location + 1);
                            break;
                        case 1:
                            neighbors[0].SetIndex(group.Location);
                            neighbors[1].SetIndex(group.Location + 2);
                            break;
                        case 2:
                            neighbors[0].SetIndex(group.Location);
                            neighbors[1].SetIndex(group.Location - 2);
                            break;
                        case 3:
                            neighbors[0].SetIndex(group.Location);
                            neighbors[1].SetIndex(group.Location - 1);
                            break;
                    }

                    break;
                    #endregion

                case EGroupTypes.LinerGroup_2_Ver:
                    #region LinerGroup_2_Ver
                    neighbors = new CMinterm[2];
                    for (int i = 0; i < 2; i++)
                        neighbors[i] = new CMinterm();

                    if (group.Location >= 0 && group.Location <= 3)
                    {
                        neighbors[0].SetIndex(group.Location);
                        neighbors[1].SetIndex(group.Location + 4);
                    }
                    else if (group.Location >= 4 && group.Location <= 7)
                    {
                        neighbors[0].SetIndex(group.Location);
                        neighbors[1].SetIndex(group.Location + 8);
                    }
                    else if (group.Location >= 8 && group.Location <= 11)
                    {
                        neighbors[0].SetIndex(group.Location);
                        neighbors[1].SetIndex(group.Location - 8);
                    }
                    else // (group.Location >= 12 && group.Location <= 15)
                    {
                        neighbors[0].SetIndex(group.Location);
                        neighbors[1].SetIndex(group.Location - 4);
                    }

                    break;
                    #endregion

                case EGroupTypes.SingleMinterm:
                    #region SingleMinterm
                    neighbors = new CMinterm[1];
                    neighbors[0] = new CMinterm();

                    neighbors[0].SetIndex(group.Location);
                    break;
                    #endregion
            }

            return neighbors;
        }

        private string GetGroupString(SCarnoGroup group)
        {
            return GetGroupString(group, m_tableLetters);
        }

        private bool IsGroupAvilableInFunctionMinterms(SCarnoGroup group)
        {
            CMinterm[] groupMinterms = GetMintermsInsideGroup(group); // Get minterms inside 'group' parameter
            int groupMintermsLength = groupMinterms.GetLength(0);

            // Controler Code
            if (m_minterms.GetLength(0) == 0) return false;
            // - - -

            for (int i = 0; i < groupMintermsLength; i++)
            {
                if (m_minterms[groupMinterms[i].GetDecimalIndex()].BoolValue)
                    continue; // Minterm found in array ! we must find next minterm in array 
                else
                    return false; // One of minterms NOT found in array , method must return false.
            }
            // 'for' loop is finished . all minterms in group parameter are in function minterms. 
            return true;


        }

        private bool IsContentEqual(bool[] array1, bool[] array2)
        {
            int arrLen1 = array1.GetLength(0);
            int arrLen2 = array2.GetLength(0);

            if (!(arrLen1 == arrLen2 && arrLen1 > 0))
                return false;

            for (int i = 0; i < arrLen1; i++)
                if (array1[i] == array2[i])
                    continue;
                else
                    return false;

            // Arrays contents are equal , we must return true
            return true;

        }

        private void InsertGroupMintermsToArray(SCarnoGroup group, bool[] ArrayToInsert)
        {
            int[] Indexes = GetMintermsIndexes(GetMintermsInsideGroup(group));

            foreach (int i in Indexes)
                ArrayToInsert[i] = true;
        }

        private bool IsGroupMintermsAvilableInArray(SCarnoGroup group, bool[] Arr)
        {
            int[] mintermsIndexes = GetMintermsIndexes(GetMintermsInsideGroup(group));
            int ArrayLen = Arr.GetLength(0);

            //
            if (ArrayLen == 0) return false;
            // - - -
            foreach (int index in mintermsIndexes)
            {
                if (index < ArrayLen)
                {
                    if (Arr[index] == true)
                        continue;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        #endregion

        #region Properties

        public char[] TableLetters
        {
            set
            {
                m_tableLetters = value;
            }
            get
            {
                return m_tableLetters;
            }
        }

        public CMinterm[] FunctionMinterms
        {
            set
            {
                m_minterms = value;
            }

            get
            {
                return m_minterms;
            }
        }

        #endregion

    }

}
