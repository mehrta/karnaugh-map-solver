using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using K_Analyzer.UserControls;
using K_Analyzer.Types;

namespace K_Analyzer.Forms
{
    public partial class frmMain : Form
    {
        // Fields
        public char m_numberDelimiter;
        public bool m_showTooltipHelps;
        private CKarnaughTable m_karnaugh3Var = new CKarnaughTable(EKarnaughTableType.Karnaugh3Var);
        private CKarnaughTable m_karnaugh4Var = new CKarnaughTable(EKarnaughTableType.Karnaugh4Var);

        // names of registry values for store application settings
        // All of following values save in "Software\\K-Analyzer" key
        private const string m_REG_APPKEY = "Software\\K-Analyzer";
        private const string m_REG_INDEXCOLOR = "IndexColor";
        private const string m_REG_FRAMECOLOR = "FrameColor";
        private const string m_REG_VALUECOLOR = "ValueColor";
        private const string m_REG_GROUPSPECIFYERCOLOR = "GroupSpecifyerColor";
        private const string m_REG_SPECIFYGROUPSVISUALY = "ShowGroupsVisualy";
        private const string m_REG_SHOWINDEXOFMINTERMS = "ShowIndexOfMinterms";
        private const string m_REG_SHOW0 = "Show0";
        private const string m_REG_SHOW1 = "Show1";
        private const string m_REG_SHOWHEADERS = "ShowHeaders";
        private const string m_REG_NUMBERDELIMITER = "NumberDelimiter";
        private const string m_REG_SHOWTOOLTIPHELPS = "ShowTooltipHelps";
        // - - - 


        public frmMain()
        {
            InitializeComponent();
        }

        #region Private User defined Methods

        private static int[] GetValidNumbers(string str, int maxValue, char delimiter)
        {
            ArrayList arrNumbers = new ArrayList();
            string[] words;
            int number;

            words = str.Split(delimiter);
            foreach (string item in words)
            {
                if (Int32.TryParse(item, out number))
                {
                    if (number >= 0 && number <= maxValue)
                        arrNumbers.Add(number);
                }
            }

            return (int[])arrNumbers.ToArray(typeof(int));
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout();
            formAbout.ShowDialog();
        }

        private void radVarsCount_CheckedChanged(object sender, EventArgs e)
        {
            if (radVarsCount3.Checked)
            {
                uctlKTable.KarnaughTableObject(m_karnaugh3Var);

                lblInputValue.Text =
                    "Value of inputs ( " + m_karnaugh3Var.TableLetters[0].ToString() +
                    ", " + m_karnaugh3Var.TableLetters[1].ToString() + ", " + m_karnaugh3Var.TableLetters[2].ToString() +
                    " )";

            }
            else
            {
                uctlKTable.KarnaughTableObject(m_karnaugh4Var);

                lblInputValue.Text =
                    "Value of inputs ( " + m_karnaugh4Var.TableLetters[0].ToString() +
                    ", " + m_karnaugh4Var.TableLetters[1].ToString() + ", " + m_karnaugh4Var.TableLetters[2].ToString() +
                    ", " + m_karnaugh4Var.TableLetters[3].ToString() + " )";

            }

            // Update outputs
            object o = new object();
            EventArgs eA = new EventArgs();
            txtDefinition_TextChanged(o, eA);
            txtInputValue_TextChanged(o, eA);
        }

        private void radDefineFunction_CheckedChanged(object sender, EventArgs e)
        {
            string str;

            if (radDefineByMinterm.Checked)
            {
                picFunctionDifinition_Paay.Visible = false;
                picFunctionDefinition_Sigma.Visible = true;
                str = "Enter Function Minterms";
            }
            else //if (radDefineByMaxterm.Checked)
            {
                picFunctionDifinition_Paay.Visible = true;
                picFunctionDefinition_Sigma.Visible = false;
                str = "Enter Function Maxterms";
            }

            lblDefinition.Text = str;
            
            // Update outputs
            object o = new object();
            EventArgs eA = new EventArgs();
            txtDefinition_TextChanged(o,eA);
            txtInputValue_TextChanged(o, eA);
            
        }

        private void txtDefinition_TextChanged(object sender, EventArgs e)
        {
            if (radVarsCount3.Checked)
            {
                if (radDefineByMinterm.Checked)
                    m_karnaugh3Var.SetFunctionByMinterms(GetValidNumbers(txtDefinition.Text, 7, m_numberDelimiter));
                else
                    m_karnaugh3Var.SetFunctionByMaxterms(GetValidNumbers(txtDefinition.Text, 7, m_numberDelimiter));

                lblMinimizedFunction.Text = m_karnaugh3Var.GetMinimizedFunctionString();
            }
            else
            {
                if (radDefineByMinterm.Checked)
                    m_karnaugh4Var.SetFunctionByMinterms(GetValidNumbers(txtDefinition.Text, 15, m_numberDelimiter));
                else
                    m_karnaugh4Var.SetFunctionByMaxterms(GetValidNumbers(txtDefinition.Text, 15, m_numberDelimiter));

                lblMinimizedFunction.Text = m_karnaugh4Var.GetMinimizedFunctionString();
            }

            uctlKTable.Invalidate();

            // Update outputs

            txtInputValue_TextChanged(new Object(), new EventArgs());

        }

        private void txtInputValue_TextChanged(object sender, EventArgs e)
        {
            const string STR_INVALID = "Invalid Input !";
            int[] validValues;
            ArrayList lstValidValues = new ArrayList();
            int decimalValue;
            string strOutput;

            // Get valid values
            validValues = GetValidNumbers(txtInputValue.Text, 1, m_numberDelimiter);
            foreach (int value in validValues)
                lstValidValues.Add(value);
            lstValidValues.Reverse();
            //

            decimalValue = BinaryManip.GetDecimalValue((int[])lstValidValues.ToArray(typeof(int)));

            if (radVarsCount3.Checked)
            {
                if (lstValidValues.Count != 3 || txtInputValue.Text.Split(m_numberDelimiter).GetLength(0) != 3)
                {
                    txtOutputValue.Text = STR_INVALID;
                    return;
                }
                if (decimalValue <= 7)
                {
                    if (m_karnaugh3Var.GetMintermValue(decimalValue))
                        strOutput = "1 (True)";
                    else
                        strOutput = "0 (False)";
                    txtOutputValue.Text = strOutput;

                }
                else
                {
                    txtOutputValue.Text = STR_INVALID;
                }
            }
            else
            {
                if (lstValidValues.Count != 4 || txtInputValue.Text.Split(m_numberDelimiter).GetLength(0) != 4)
                {
                    txtOutputValue.Text = STR_INVALID;
                    return;
                }
                if (decimalValue <= 15)
                {
                    if (m_karnaugh4Var.GetMintermValue(decimalValue))
                        strOutput = "1 (True)";
                    else
                        strOutput = "0 (False)";
                    txtOutputValue.Text = strOutput;
                }
                else
                {
                    txtOutputValue.Text = STR_INVALID;
                }
            }
        }

        private void chklstOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool newValueOfItem = e.NewValue == CheckState.Checked ? true : false;

            switch (e.Index)
            {
                case 0:
                    //Indicate groups in karnaugh table visualy
                    uctlKTable.SpecifyFunctionGroupsVisualy = newValueOfItem;
                    break;
                case 1:
                    //Show index of each minterm
                    uctlKTable.ShowMintermsIndex = newValueOfItem;
                    break;
                case 2:
                    //Do not show 0 (false) value of minterms
                    uctlKTable.ShowValue0 = !newValueOfItem;
                    break;
                case 3:
                    //Do not show 1 (true) value of minterms
                    uctlKTable.ShowValue1 = !newValueOfItem;
                    break;
                case 4:
                    //Show table headers
                    uctlKTable.ShowLables = newValueOfItem;
                    break;
                case 5:
                    // Enable ToolTip Helps
                    m_showTooltipHelps = toolTip.Active = newValueOfItem;
                    enableDynamicHelpsToolStripMenuItem.Checked = newValueOfItem;
                    break;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Save settings to windows registry
            try
            {
                RegistryKey AppKey = Registry.CurrentUser.CreateSubKey(m_REG_APPKEY);
                // Write color values
                AppKey.SetValue(m_REG_INDEXCOLOR, Color.FromArgb(100, 100, 102, 234).ToArgb());
                AppKey.SetValue(m_REG_FRAMECOLOR, uctlKTable.FrameColor.ToArgb());
                AppKey.SetValue(m_REG_VALUECOLOR, uctlKTable.MintermValueColor.ToArgb());
                AppKey.SetValue(m_REG_GROUPSPECIFYERCOLOR, uctlKTable.GroupSpecifyerColor.ToArgb());
                // Write Bool values
                AppKey.SetValue(m_REG_SPECIFYGROUPSVISUALY, chklstOptions.GetItemChecked(0) ? 1 : 0);
                AppKey.SetValue(m_REG_SHOWINDEXOFMINTERMS, chklstOptions.GetItemChecked(1) ? 1 : 0);
                AppKey.SetValue(m_REG_SHOW0, chklstOptions.GetItemChecked(2) ? 1 : 0);
                AppKey.SetValue(m_REG_SHOW1, chklstOptions.GetItemChecked(3) ? 1 : 0);
                AppKey.SetValue(m_REG_SHOWHEADERS, chklstOptions.GetItemChecked(4) ? 1 : 0);
                // Write Other values
                AppKey.SetValue(m_REG_NUMBERDELIMITER, m_numberDelimiter);
                AppKey.SetValue(m_REG_SHOWTOOLTIPHELPS, m_showTooltipHelps ? 1 : 0);
                //
                AppKey.Close();
            }
            catch
            {
                MessageBox.Show("There is a problem in accessing to windows registry."
                    + "\n  Application settings will not save.", "Error in saving progress", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Load settings from windows registry
            try
            {
                RegistryKey AppKey = Registry.CurrentUser.OpenSubKey(m_REG_APPKEY);
                if (AppKey == null)
                    AppKey = Registry.CurrentUser.CreateSubKey(m_REG_APPKEY);

                // Read color values
                uctlKTable.MintermIndexColor = Color.FromArgb((int)AppKey.GetValue(m_REG_INDEXCOLOR, Color.Green.ToArgb()));
                uctlKTable.FrameColor = Color.FromArgb((int)AppKey.GetValue(m_REG_FRAMECOLOR, Color.Green.ToArgb()));
                uctlKTable.MintermValueColor = Color.FromArgb((int)AppKey.GetValue(m_REG_VALUECOLOR, Color.Green.ToArgb()));
                uctlKTable.GroupSpecifyerColor = Color.FromArgb((int)AppKey.GetValue(m_REG_GROUPSPECIFYERCOLOR, Color.Green.ToArgb()));
                //
                // Read Bool values
                chklstOptions.SetItemChecked(0,
                    ((int)AppKey.GetValue(m_REG_SPECIFYGROUPSVISUALY, 1)) != 0 ? true : false);

                chklstOptions.SetItemChecked(1,
                    ((int)AppKey.GetValue(m_REG_SHOWINDEXOFMINTERMS, 1)) != 0 ? true : false);

                chklstOptions.SetItemChecked(2,
                    ((int)AppKey.GetValue(m_REG_SHOW0, 0)) != 0 ? true : false);

                chklstOptions.SetItemChecked(3,
                    ((int)AppKey.GetValue(m_REG_SHOW1, 0)) != 0 ? true : false);

                chklstOptions.SetItemChecked(4,
                    ((int)AppKey.GetValue(m_REG_SHOWHEADERS, 1)) != 0 ? true : false);
                //
                // Read other values
                bool blnValue;
                m_numberDelimiter = Convert.ToChar(AppKey.GetValue(m_REG_NUMBERDELIMITER, (object)','));

                blnValue = (int)AppKey.GetValue(m_REG_SHOWTOOLTIPHELPS, 1) != 0 ? true : false;
                m_showTooltipHelps = toolTip.Active = blnValue;
                chklstOptions.SetItemChecked(5, blnValue);
                //

                AppKey.Close();
            }

            catch
            {
                MessageBox.Show("There is a problem in the application settings that are saved in registry."
                  + "\n  Some settings are not loaded.", "Error in loading progress", MessageBoxButtons.OK,
                  MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            #endregion

            // Attach m_karnaughTable to uctlKarnaughTable
            uctlKTable.KarnaughTableObject(m_karnaugh3Var);

            //
            // Apply some settings
            resetToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private void lnkMoreOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OptionstoolStripMenuItem_Click(new object(), new EventArgs());
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDefinition.Text = "";
            txtInputValue.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlKTable.ApplyColorMode(ctlKarnaughTable.EColorMode.Default);
        }

        private void mode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlKTable.ApplyColorMode(ctlKarnaughTable.EColorMode.Mode1);
        }

        private void mode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlKTable.ApplyColorMode(ctlKarnaughTable.EColorMode.Mode2);
        }

        private void mode3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlKTable.ApplyColorMode(ctlKarnaughTable.EColorMode.Mode3);
        }

        private void OptionstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions optionsForm = new frmOptions();
            optionsForm.m_frmMain = this;
            optionsForm.ShowDialog(this);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlKTable.Refresh();
        }

        private void enableTooltipHelpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_showTooltipHelps = toolTip.Active = enableDynamicHelpsToolStripMenuItem.Checked;
            chklstOptions.SetItemChecked(5, m_showTooltipHelps);
        }
    }

}