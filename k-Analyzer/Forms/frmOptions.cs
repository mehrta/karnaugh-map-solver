using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using K_Analyzer.UserControls;

namespace K_Analyzer.Forms
{
    public partial class frmOptions : Form
    {
        // Fields
        public frmMain m_frmMain; // A refrence to 'frmMain'
        private int m_ButtonClickedIndex;
        //


        private void ShowColorMenu(Button clickedButton)
        {
            Point p = new Point();

            p.X = clickedButton.ClientRectangle.Left;
            p.Y = clickedButton.ClientRectangle.Bottom;
            p = clickedButton.PointToScreen(p);

            cmnuColors.Show(p);
        }

        public frmOptions()
        {
            InitializeComponent();

        }

        private void SetPicturesBackcolor(K_Analyzer.UserControls.ctlKarnaughTable sourceKarnoTable)
        {
            picTableBorder.BackColor = sourceKarnoTable.FrameColor;
            picGroupSpecifyer.BackColor = sourceKarnoTable.GroupSpecifyerColor;
            picCellsIndex.BackColor = sourceKarnoTable.MintermIndexColor;
            picLables.BackColor = sourceKarnoTable.LableColor;
            picBinaryHeaders.BackColor = sourceKarnoTable.LableBitsColor;
            picVerAndHorLines.BackColor = sourceKarnoTable.BracketColor;
            picMintermValue.BackColor = sourceKarnoTable.MintermValueColor;
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {            
            // Apply general settings
            toolTip.Active = m_frmMain.toolTip.Active;
            // Apply Tab 1 settings
            chkSpecifyGroupsVisualy.Checked = m_frmMain.chklstOptions.GetItemChecked(0);
            chkShowMintermsIndex.Checked = m_frmMain.chklstOptions.GetItemChecked(1);
            chkDontShow0.Checked = m_frmMain.chklstOptions.GetItemChecked(2);
            chkDontShow1.Checked = m_frmMain.chklstOptions.GetItemChecked(3);
            chkShowTableHeaders.Checked = m_frmMain.chklstOptions.GetItemChecked(4);
            int selectedIndex=0;
            switch (m_frmMain.m_numberDelimiter)
            {
                case ',':
                    selectedIndex = 0;
                    break;
                case '+':
                    selectedIndex = 1;
                    break;
                case '-':
                    selectedIndex = 2;
                    break;
            }
            cmbNumberDelimiter.SelectedIndex = selectedIndex;
            //
            // Apply Tab 2 settings
            SetPicturesBackcolor(m_frmMain.uctlKTable);
        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            m_ButtonClickedIndex = int.Parse((string)((Button)sender).Tag);
            ShowColorMenu((Button)sender);
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            Color clr;

            if ((string)menuItem.Tag != "9")
            {
                clr = menuItem.BackColor;
            }
            else
            {
                colorDialog.ShowDialog();
                clr = colorDialog.Color;
            }

            switch (m_ButtonClickedIndex)
            {
                case 0:
                    picTableBorder.BackColor = clr;
                    break;
                case 1:
                    picGroupSpecifyer.BackColor = clr;
                    break;
                case 2:
                    picCellsIndex.BackColor = clr;
                    break;
                case 3:
                    picLables.BackColor = clr;
                    break;
                case 4:
                    picBinaryHeaders.BackColor = clr;
                    break;
                case 5:
                    picVerAndHorLines.BackColor = clr;
                    break;
                case 6:
                    picMintermValue.BackColor = clr;
                    break;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Apply Settings
            // Tab 1
            m_frmMain.uctlKTable.UpdateGUI = false;
            m_frmMain.uctlKTable.FrameColor = uctlSampleTable.FrameColor;
            m_frmMain.uctlKTable.GroupSpecifyerColor = uctlSampleTable.GroupSpecifyerColor;
            m_frmMain.uctlKTable.MintermIndexColor = uctlSampleTable.MintermIndexColor;
            m_frmMain.uctlKTable.LableColor = uctlSampleTable.LableColor;
            m_frmMain.uctlKTable.LableBitsColor = uctlSampleTable.LableBitsColor;
            m_frmMain.uctlKTable.BracketColor = uctlSampleTable.BracketColor;
            m_frmMain.uctlKTable.MintermValueColor = uctlSampleTable.MintermValueColor;
            m_frmMain.uctlKTable.UpdateGUI = true;
            //
            // Tab 2
            m_frmMain.chklstOptions.SetItemChecked(0, chkSpecifyGroupsVisualy.Checked);
            m_frmMain.chklstOptions.SetItemChecked(1, chkShowMintermsIndex.Checked);
            m_frmMain.chklstOptions.SetItemChecked(2, chkDontShow0.Checked);
            m_frmMain.chklstOptions.SetItemChecked(3, chkDontShow1.Checked);
            m_frmMain.chklstOptions.SetItemChecked(4, chkShowTableHeaders.Checked);
            m_frmMain.m_numberDelimiter = Convert.ToChar(Convert.ToString(cmbNumberDelimiter.SelectedItem).Trim());
            //
            this.Close();
        }

        private void picTableBorder_BackColorChanged(object sender, EventArgs e)
        {
            uctlSampleTable.FrameColor = picTableBorder.BackColor;
        }

        private void picGroupSpecifyer_Click(object sender, EventArgs e)
        {
            uctlSampleTable.GroupSpecifyerColor = picGroupSpecifyer.BackColor;
        }

        private void picCellsIndex_BackColorChanged(object sender, EventArgs e)
        {
            uctlSampleTable.MintermIndexColor = picCellsIndex.BackColor;
        }

        private void picLables_BackColorChanged(object sender, EventArgs e)
        {
            uctlSampleTable.LableColor = picLables.BackColor;
        }

        private void picBinaryHeaders_BackColorChanged(object sender, EventArgs e)
        {
            uctlSampleTable.LableBitsColor = picBinaryHeaders.BackColor;
        }

        private void picVerAndHorLines_BackColorChanged(object sender, EventArgs e)
        {
            uctlSampleTable.BracketColor = picVerAndHorLines.BackColor;
        }

        private void picMintermValue_BackColorChanged(object sender, EventArgs e)
        {
            uctlSampleTable.MintermValueColor = picMintermValue.BackColor;
        }

        private void btn_ColorModes_Click(object sender, EventArgs e)
        {
            ctlKarnaughTable.EColorMode colorMode =(ctlKarnaughTable.EColorMode) int.Parse((string)((Button)sender).Tag);
            uctlSampleTable.ApplyColorMode(colorMode);
            SetPicturesBackcolor(uctlSampleTable);
        }

        private void tabPageGeneral_Click(object sender, EventArgs e)
        {

        }

        private void cmbNumberDelimiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str="";

            switch (cmbNumberDelimiter.SelectedIndex)
            {
                case 0:
                    str = "(Comma)";
                    break;
                case 1:
                    str = "(positive sign)";
                    break;
                case 2:
                    str = "(minus sign)";
                    break;
            }
            lblNumberDelimiter.Text = str;

        }

        private void frmOptions_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}