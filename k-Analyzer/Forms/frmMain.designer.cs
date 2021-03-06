namespace K_Analyzer.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gboxDefinition = new System.Windows.Forms.GroupBox();
            this.picFunctionDefinition_Sigma = new System.Windows.Forms.PictureBox();
            this.picFunctionDifinition_Paay = new System.Windows.Forms.PictureBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.pnlVariablesCount = new System.Windows.Forms.Panel();
            this.radVarsCount3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radVarsCount4 = new System.Windows.Forms.RadioButton();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.radDefineByMaxterm = new System.Windows.Forms.RadioButton();
            this.radDefineByMinterm = new System.Windows.Forms.RadioButton();
            this.gboxEvaluator = new System.Windows.Forms.GroupBox();
            this.lblOutputValue = new System.Windows.Forms.Label();
            this.lblInputValue = new System.Windows.Forms.Label();
            this.txtOutputValue = new System.Windows.Forms.TextBox();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.lnkMoreOptions = new System.Windows.Forms.LinkLabel();
            this.chklstOptions = new System.Windows.Forms.CheckedListBox();
            this.gboxMinimizedFunction = new System.Windows.Forms.GroupBox();
            this.lblMinimizedFunction = new System.Windows.Forms.Label();
            this.picMinimizedFunction = new System.Windows.Forms.PictureBox();
            this.lbl_STATIC = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDynamicHelpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripKTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorModesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mode1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mode2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mode3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uctlKTable = new K_Analyzer.UserControls.ctlKarnaughTable();
            this.gboxDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFunctionDefinition_Sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFunctionDifinition_Paay)).BeginInit();
            this.pnlVariablesCount.SuspendLayout();
            this.gboxEvaluator.SuspendLayout();
            this.gboxOptions.SuspendLayout();
            this.gboxMinimizedFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizedFunction)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStripKTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDefinition
            // 
            this.gboxDefinition.Controls.Add(this.picFunctionDefinition_Sigma);
            this.gboxDefinition.Controls.Add(this.picFunctionDifinition_Paay);
            this.gboxDefinition.Controls.Add(this.txtDefinition);
            this.gboxDefinition.Controls.Add(this.pnlVariablesCount);
            this.gboxDefinition.Controls.Add(this.lblDefinition);
            this.gboxDefinition.Controls.Add(this.radDefineByMaxterm);
            this.gboxDefinition.Controls.Add(this.radDefineByMinterm);
            this.gboxDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDefinition.ForeColor = System.Drawing.Color.Blue;
            this.gboxDefinition.Location = new System.Drawing.Point(8, 72);
            this.gboxDefinition.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.gboxDefinition.MaximumSize = new System.Drawing.Size(5000, 200);
            this.gboxDefinition.MinimumSize = new System.Drawing.Size(290, 180);
            this.gboxDefinition.Name = "gboxDefinition";
            this.gboxDefinition.Padding = new System.Windows.Forms.Padding(0);
            this.gboxDefinition.Size = new System.Drawing.Size(290, 180);
            this.gboxDefinition.TabIndex = 0;
            this.gboxDefinition.TabStop = false;
            this.gboxDefinition.Text = "Definition Of Boolean Function ";
            // 
            // picFunctionDefinition_Sigma
            // 
            this.picFunctionDefinition_Sigma.Image = ((System.Drawing.Image)(resources.GetObject("picFunctionDefinition_Sigma.Image")));
            this.picFunctionDefinition_Sigma.Location = new System.Drawing.Point(9, 137);
            this.picFunctionDefinition_Sigma.Name = "picFunctionDefinition_Sigma";
            this.picFunctionDefinition_Sigma.Size = new System.Drawing.Size(28, 26);
            this.picFunctionDefinition_Sigma.TabIndex = 9;
            this.picFunctionDefinition_Sigma.TabStop = false;
            // 
            // picFunctionDifinition_Paay
            // 
            this.picFunctionDifinition_Paay.Image = ((System.Drawing.Image)(resources.GetObject("picFunctionDifinition_Paay.Image")));
            this.picFunctionDifinition_Paay.Location = new System.Drawing.Point(9, 137);
            this.picFunctionDifinition_Paay.Name = "picFunctionDifinition_Paay";
            this.picFunctionDifinition_Paay.Size = new System.Drawing.Size(28, 26);
            this.picFunctionDifinition_Paay.TabIndex = 9;
            this.picFunctionDifinition_Paay.TabStop = false;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinition.Location = new System.Drawing.Point(39, 142);
            this.txtDefinition.MaximumSize = new System.Drawing.Size(270, 21);
            this.txtDefinition.MinimumSize = new System.Drawing.Size(80, 21);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(238, 21);
            this.txtDefinition.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtDefinition, "مينترم يا ماكسترم هاي تابع را در اين جعبه متن وارد كنيد");
            this.txtDefinition.TextChanged += new System.EventHandler(this.txtDefinition_TextChanged);
            // 
            // pnlVariablesCount
            // 
            this.pnlVariablesCount.Controls.Add(this.radVarsCount3);
            this.pnlVariablesCount.Controls.Add(this.label1);
            this.pnlVariablesCount.Controls.Add(this.radVarsCount4);
            this.pnlVariablesCount.Location = new System.Drawing.Point(6, 25);
            this.pnlVariablesCount.Name = "pnlVariablesCount";
            this.pnlVariablesCount.Size = new System.Drawing.Size(281, 25);
            this.pnlVariablesCount.TabIndex = 8;
            // 
            // radVarsCount3
            // 
            this.radVarsCount3.AutoSize = true;
            this.radVarsCount3.Checked = true;
            this.radVarsCount3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radVarsCount3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radVarsCount3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radVarsCount3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radVarsCount3.Location = new System.Drawing.Point(91, 3);
            this.radVarsCount3.Name = "radVarsCount3";
            this.radVarsCount3.Size = new System.Drawing.Size(87, 17);
            this.radVarsCount3.TabIndex = 0;
            this.radVarsCount3.TabStop = true;
            this.radVarsCount3.Text = "3 Variables";
            this.toolTip.SetToolTip(this.radVarsCount3, "با انتخاب اين گزينه تابع ورودي 3 متغيره فرض مي شود");
            this.radVarsCount3.UseVisualStyleBackColor = true;
            this.radVarsCount3.CheckedChanged += new System.EventHandler(this.radVarsCount_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Variables count :";
            // 
            // radVarsCount4
            // 
            this.radVarsCount4.AutoSize = true;
            this.radVarsCount4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radVarsCount4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radVarsCount4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radVarsCount4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radVarsCount4.Location = new System.Drawing.Point(184, 3);
            this.radVarsCount4.Name = "radVarsCount4";
            this.radVarsCount4.Size = new System.Drawing.Size(87, 17);
            this.radVarsCount4.TabIndex = 1;
            this.radVarsCount4.Text = "4 Variables";
            this.toolTip.SetToolTip(this.radVarsCount4, "با انتخاب اين گزينه تابع ورودي 4 متغيره فرض مي شود");
            this.radVarsCount4.UseVisualStyleBackColor = true;
            this.radVarsCount4.CheckedChanged += new System.EventHandler(this.radVarsCount_CheckedChanged);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.ForeColor = System.Drawing.Color.Navy;
            this.lblDefinition.Location = new System.Drawing.Point(36, 126);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(144, 13);
            this.lblDefinition.TabIndex = 4;
            this.lblDefinition.Text = "Enter Function Minterms";
            // 
            // radDefineByMaxterm
            // 
            this.radDefineByMaxterm.AutoSize = true;
            this.radDefineByMaxterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDefineByMaxterm.ForeColor = System.Drawing.Color.Black;
            this.radDefineByMaxterm.Location = new System.Drawing.Point(9, 100);
            this.radDefineByMaxterm.Name = "radDefineByMaxterm";
            this.radDefineByMaxterm.Size = new System.Drawing.Size(162, 17);
            this.radDefineByMaxterm.TabIndex = 1;
            this.radDefineByMaxterm.Text = "Define function by Maxterms ";
            this.toolTip.SetToolTip(this.radDefineByMaxterm, "با انتخاب اين گزينه شما بايد ماكسترم هاي تابع را در جعبه متن پايين وارد كنيد");
            this.radDefineByMaxterm.UseVisualStyleBackColor = true;
            // 
            // radDefineByMinterm
            // 
            this.radDefineByMinterm.AutoSize = true;
            this.radDefineByMinterm.Checked = true;
            this.radDefineByMinterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDefineByMinterm.ForeColor = System.Drawing.Color.Black;
            this.radDefineByMinterm.Location = new System.Drawing.Point(9, 77);
            this.radDefineByMinterm.Name = "radDefineByMinterm";
            this.radDefineByMinterm.Size = new System.Drawing.Size(159, 17);
            this.radDefineByMinterm.TabIndex = 0;
            this.radDefineByMinterm.TabStop = true;
            this.radDefineByMinterm.Text = "Define function by Minterms ";
            this.toolTip.SetToolTip(this.radDefineByMinterm, "با انتخاب اين گزينه شما بايد مينترم هاي تابع را در جعبه متن پايين وارد كنيد");
            this.radDefineByMinterm.UseVisualStyleBackColor = true;
            this.radDefineByMinterm.CheckedChanged += new System.EventHandler(this.radDefineFunction_CheckedChanged);
            // 
            // gboxEvaluator
            // 
            this.gboxEvaluator.Controls.Add(this.lblOutputValue);
            this.gboxEvaluator.Controls.Add(this.lblInputValue);
            this.gboxEvaluator.Controls.Add(this.txtOutputValue);
            this.gboxEvaluator.Controls.Add(this.txtInputValue);
            this.gboxEvaluator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEvaluator.ForeColor = System.Drawing.Color.Blue;
            this.gboxEvaluator.Location = new System.Drawing.Point(8, 260);
            this.gboxEvaluator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.gboxEvaluator.MaximumSize = new System.Drawing.Size(5000, 100);
            this.gboxEvaluator.MinimumSize = new System.Drawing.Size(290, 80);
            this.gboxEvaluator.Name = "gboxEvaluator";
            this.gboxEvaluator.Size = new System.Drawing.Size(290, 80);
            this.gboxEvaluator.TabIndex = 1;
            this.gboxEvaluator.TabStop = false;
            this.gboxEvaluator.Text = "Function Evaluator ";
            // 
            // lblOutputValue
            // 
            this.lblOutputValue.AutoSize = true;
            this.lblOutputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputValue.ForeColor = System.Drawing.Color.Black;
            this.lblOutputValue.Location = new System.Drawing.Point(6, 53);
            this.lblOutputValue.Name = "lblOutputValue";
            this.lblOutputValue.Size = new System.Drawing.Size(104, 13);
            this.lblOutputValue.TabIndex = 0;
            this.lblOutputValue.Text = "Value of function";
            // 
            // lblInputValue
            // 
            this.lblInputValue.AutoSize = true;
            this.lblInputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputValue.ForeColor = System.Drawing.Color.Black;
            this.lblInputValue.Location = new System.Drawing.Point(6, 24);
            this.lblInputValue.Name = "lblInputValue";
            this.lblInputValue.Size = new System.Drawing.Size(122, 13);
            this.lblInputValue.TabIndex = 0;
            this.lblInputValue.Text = "Value of inputs ( A, B, C)";
            // 
            // txtOutputValue
            // 
            this.txtOutputValue.BackColor = System.Drawing.Color.White;
            this.txtOutputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputValue.ForeColor = System.Drawing.Color.Gray;
            this.txtOutputValue.Location = new System.Drawing.Point(154, 48);
            this.txtOutputValue.MaximumSize = new System.Drawing.Size(270, 21);
            this.txtOutputValue.MinimumSize = new System.Drawing.Size(20, 21);
            this.txtOutputValue.Name = "txtOutputValue";
            this.txtOutputValue.ReadOnly = true;
            this.txtOutputValue.Size = new System.Drawing.Size(123, 21);
            this.txtOutputValue.TabIndex = 1;
            this.txtOutputValue.Text = "0";
            this.toolTip.SetToolTip(this.txtOutputValue, "خروجي تابع به ازاي متغير هاي ورودي");
            // 
            // txtInputValue
            // 
            this.txtInputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputValue.ForeColor = System.Drawing.Color.Black;
            this.txtInputValue.Location = new System.Drawing.Point(154, 19);
            this.txtInputValue.MaximumSize = new System.Drawing.Size(270, 21);
            this.txtInputValue.MinimumSize = new System.Drawing.Size(20, 21);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(123, 21);
            this.txtInputValue.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtInputValue, "متغير هاي ورودي تابع را در اين جعبه متن وارد كنيد تا خروجي تابع محاسبه شده و در ج" +
        "عبه متن پايين نمايش داده شود");
            this.txtInputValue.TextChanged += new System.EventHandler(this.txtInputValue_TextChanged);
            // 
            // gboxOptions
            // 
            this.gboxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxOptions.BackColor = System.Drawing.Color.White;
            this.gboxOptions.Controls.Add(this.lnkMoreOptions);
            this.gboxOptions.Controls.Add(this.chklstOptions);
            this.gboxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxOptions.ForeColor = System.Drawing.Color.Blue;
            this.gboxOptions.Location = new System.Drawing.Point(8, 346);
            this.gboxOptions.MaximumSize = new System.Drawing.Size(5000, 100000);
            this.gboxOptions.MinimumSize = new System.Drawing.Size(290, 100);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.gboxOptions.Size = new System.Drawing.Size(290, 115);
            this.gboxOptions.TabIndex = 10;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options ";
            // 
            // lnkMoreOptions
            // 
            this.lnkMoreOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkMoreOptions.AutoSize = true;
            this.lnkMoreOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkMoreOptions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkMoreOptions.Location = new System.Drawing.Point(7, 93);
            this.lnkMoreOptions.Name = "lnkMoreOptions";
            this.lnkMoreOptions.Size = new System.Drawing.Size(80, 13);
            this.lnkMoreOptions.TabIndex = 1;
            this.lnkMoreOptions.TabStop = true;
            this.lnkMoreOptions.Text = "More options";
            this.lnkMoreOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMoreOptions_LinkClicked);
            // 
            // chklstOptions
            // 
            this.chklstOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklstOptions.CheckOnClick = true;
            this.chklstOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstOptions.ForeColor = System.Drawing.Color.DimGray;
            this.chklstOptions.FormattingEnabled = true;
            this.chklstOptions.Items.AddRange(new object[] {
            "Indicate groups in Karnaugh table visualy",
            "Show index of each minterm",
            "Do not show 0 (false) value of minterms",
            "Do not show 1 (true) value of minterms",
            "Show table headers",
            "Enable ToolTip Helps"});
            this.chklstOptions.Location = new System.Drawing.Point(10, 21);
            this.chklstOptions.Name = "chklstOptions";
            this.chklstOptions.Size = new System.Drawing.Size(274, 60);
            this.chklstOptions.TabIndex = 0;
            this.chklstOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstOptions_ItemCheck);
            // 
            // gboxMinimizedFunction
            // 
            this.gboxMinimizedFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxMinimizedFunction.Controls.Add(this.lblMinimizedFunction);
            this.gboxMinimizedFunction.Controls.Add(this.picMinimizedFunction);
            this.gboxMinimizedFunction.Controls.Add(this.lbl_STATIC);
            this.gboxMinimizedFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMinimizedFunction.Location = new System.Drawing.Point(309, 408);
            this.gboxMinimizedFunction.Margin = new System.Windows.Forms.Padding(5);
            this.gboxMinimizedFunction.MinimumSize = new System.Drawing.Size(200, 0);
            this.gboxMinimizedFunction.Name = "gboxMinimizedFunction";
            this.gboxMinimizedFunction.Size = new System.Drawing.Size(434, 53);
            this.gboxMinimizedFunction.TabIndex = 13;
            this.gboxMinimizedFunction.TabStop = false;
            this.gboxMinimizedFunction.Text = "Minimized Function ";
            // 
            // lblMinimizedFunction
            // 
            this.lblMinimizedFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimizedFunction.AutoSize = true;
            this.lblMinimizedFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizedFunction.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMinimizedFunction.Location = new System.Drawing.Point(67, 26);
            this.lblMinimizedFunction.Margin = new System.Windows.Forms.Padding(0);
            this.lblMinimizedFunction.Name = "lblMinimizedFunction";
            this.lblMinimizedFunction.Size = new System.Drawing.Size(27, 15);
            this.lblMinimizedFunction.TabIndex = 0;
            this.lblMinimizedFunction.Text = " lbl";
            this.toolTip.SetToolTip(this.lblMinimizedFunction, "تابع مينيمايز شده");
            // 
            // picMinimizedFunction
            // 
            this.picMinimizedFunction.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizedFunction.Image")));
            this.picMinimizedFunction.Location = new System.Drawing.Point(6, 15);
            this.picMinimizedFunction.Name = "picMinimizedFunction";
            this.picMinimizedFunction.Size = new System.Drawing.Size(32, 32);
            this.picMinimizedFunction.TabIndex = 1;
            this.picMinimizedFunction.TabStop = false;
            // 
            // lbl_STATIC
            // 
            this.lbl_STATIC.AutoSize = true;
            this.lbl_STATIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_STATIC.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_STATIC.Location = new System.Drawing.Point(45, 26);
            this.lbl_STATIC.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_STATIC.Name = "lbl_STATIC";
            this.lbl_STATIC.Size = new System.Drawing.Size(33, 16);
            this.lbl_STATIC.TabIndex = 0;
            this.lbl_STATIC.Text = "F =";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 20000;
            this.toolTip.BackColor = System.Drawing.Color.Yellow;
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(754, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(99, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorModesToolStripMenuItem,
            this.toolStripSeparator3,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator4,
            this.refreshToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorModesToolStripMenuItem
            // 
            this.colorModesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.toolStripSeparator2,
            this.mode1ToolStripMenuItem,
            this.mode2ToolStripMenuItem,
            this.mode3ToolStripMenuItem});
            this.colorModesToolStripMenuItem.Name = "colorModesToolStripMenuItem";
            this.colorModesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.colorModesToolStripMenuItem.Text = "Color Modes";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // mode1ToolStripMenuItem
            // 
            this.mode1ToolStripMenuItem.Name = "mode1ToolStripMenuItem";
            this.mode1ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.mode1ToolStripMenuItem.Text = "Mode 1";
            this.mode1ToolStripMenuItem.Click += new System.EventHandler(this.mode1ToolStripMenuItem_Click);
            // 
            // mode2ToolStripMenuItem
            // 
            this.mode2ToolStripMenuItem.Name = "mode2ToolStripMenuItem";
            this.mode2ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.mode2ToolStripMenuItem.Text = "Mode 2";
            this.mode2ToolStripMenuItem.Click += new System.EventHandler(this.mode2ToolStripMenuItem_Click);
            // 
            // mode3ToolStripMenuItem
            // 
            this.mode3ToolStripMenuItem.Name = "mode3ToolStripMenuItem";
            this.mode3ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.mode3ToolStripMenuItem.Text = "Mode 3";
            this.mode3ToolStripMenuItem.Click += new System.EventHandler(this.mode3ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionstoolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(139, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDynamicHelpsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // enableDynamicHelpsToolStripMenuItem
            // 
            this.enableDynamicHelpsToolStripMenuItem.CheckOnClick = true;
            this.enableDynamicHelpsToolStripMenuItem.Name = "enableDynamicHelpsToolStripMenuItem";
            this.enableDynamicHelpsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.enableDynamicHelpsToolStripMenuItem.Text = "Enable Dynamic Helps";
            this.enableDynamicHelpsToolStripMenuItem.Click += new System.EventHandler(this.enableTooltipHelpsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(189, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aboutToolStripMenuItem.Text = "About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReset,
            this.toolStripButtonOptions,
            this.toolStripSeparator6,
            this.toolStripButtonAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(754, 39);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonReset
            // 
            this.toolStripButtonReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReset.Image")));
            this.toolStripButtonReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReset.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.toolStripButtonReset.Name = "toolStripButtonReset";
            this.toolStripButtonReset.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonReset.Text = "Reset";
            this.toolStripButtonReset.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripButtonOptions
            // 
            this.toolStripButtonOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOptions.Image")));
            this.toolStripButtonOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOptions.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.toolStripButtonOptions.Name = "toolStripButtonOptions";
            this.toolStripButtonOptions.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonOptions.Text = "Options";
            this.toolStripButtonOptions.Click += new System.EventHandler(this.OptionstoolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonAbout.Text = "About ...";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStripKTable
            // 
            this.contextMenuStripKTable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripKTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorModesToolStripMenuItem1,
            this.refreshToolStripMenuItem1});
            this.contextMenuStripKTable.Name = "contextMenuStripKTable";
            this.contextMenuStripKTable.Size = new System.Drawing.Size(151, 48);
            // 
            // colorModesToolStripMenuItem1
            // 
            this.colorModesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem2,
            this.toolStripSeparator7,
            this.mode1ToolStripMenuItem1,
            this.mode2ToolStripMenuItem1,
            this.mode3ToolStripMenuItem1});
            this.colorModesToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorModesToolStripMenuItem1.Name = "colorModesToolStripMenuItem1";
            this.colorModesToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.colorModesToolStripMenuItem1.Text = "Color Modes";
            // 
            // defaultToolStripMenuItem2
            // 
            this.defaultToolStripMenuItem2.ForeColor = System.Drawing.Color.Blue;
            this.defaultToolStripMenuItem2.Name = "defaultToolStripMenuItem2";
            this.defaultToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.defaultToolStripMenuItem2.Text = "Default";
            this.defaultToolStripMenuItem2.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(117, 6);
            // 
            // mode1ToolStripMenuItem1
            // 
            this.mode1ToolStripMenuItem1.Name = "mode1ToolStripMenuItem1";
            this.mode1ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.mode1ToolStripMenuItem1.Text = "Mode 1";
            this.mode1ToolStripMenuItem1.Click += new System.EventHandler(this.mode1ToolStripMenuItem_Click);
            // 
            // mode2ToolStripMenuItem1
            // 
            this.mode2ToolStripMenuItem1.Name = "mode2ToolStripMenuItem1";
            this.mode2ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.mode2ToolStripMenuItem1.Text = "Mode 2";
            this.mode2ToolStripMenuItem1.Click += new System.EventHandler(this.mode2ToolStripMenuItem_Click);
            // 
            // mode3ToolStripMenuItem1
            // 
            this.mode3ToolStripMenuItem1.Name = "mode3ToolStripMenuItem1";
            this.mode3ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.mode3ToolStripMenuItem1.Text = "Mode 3";
            this.mode3ToolStripMenuItem1.Click += new System.EventHandler(this.mode3ToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // uctlKTable
            // 
            this.uctlKTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctlKTable.BackColor = System.Drawing.Color.White;
            this.uctlKTable.BorderColor = System.Drawing.Color.Silver;
            this.uctlKTable.BracketColor = System.Drawing.Color.Silver;
            this.uctlKTable.ColorAlpha = 100;
            this.uctlKTable.ContextMenuStrip = this.contextMenuStripKTable;
            this.uctlKTable.FrameColor = System.Drawing.Color.Green;
            this.uctlKTable.GroupSpecifyerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.uctlKTable.IndexFont = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctlKTable.LableBitFont = new System.Drawing.Font("Arial", 10F);
            this.uctlKTable.LableBitsColor = System.Drawing.Color.Gray;
            this.uctlKTable.LableColor = System.Drawing.Color.Blue;
            this.uctlKTable.LableFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctlKTable.Location = new System.Drawing.Point(309, 78);
            this.uctlKTable.Margin = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.uctlKTable.MinimumSize = new System.Drawing.Size(200, 200);
            this.uctlKTable.MintermIndexColor = System.Drawing.Color.Gray;
            this.uctlKTable.MintermValueColor = System.Drawing.Color.Green;
            this.uctlKTable.Name = "uctlKTable";
            this.uctlKTable.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.uctlKTable.ShowLables = true;
            this.uctlKTable.ShowMintermsIndex = true;
            this.uctlKTable.ShowValue0 = true;
            this.uctlKTable.ShowValue1 = true;
            this.uctlKTable.Size = new System.Drawing.Size(434, 325);
            this.uctlKTable.SpecifyFunctionGroupsVisualy = true;
            this.uctlKTable.TabIndex = 0;
            this.uctlKTable.TableLocation = new System.Drawing.Point(50, 50);
            this.uctlKTable.UpdateGUI = true;
            this.uctlKTable.ValueFont = new System.Drawing.Font("Arial", 12F);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 471);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.gboxMinimizedFunction);
            this.Controls.Add(this.gboxDefinition);
            this.Controls.Add(this.gboxEvaluator);
            this.Controls.Add(this.uctlKTable);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(530, 490);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-Analyzer 1.0 (Karnaugh Map Solver)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gboxDefinition.ResumeLayout(false);
            this.gboxDefinition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFunctionDefinition_Sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFunctionDifinition_Paay)).EndInit();
            this.pnlVariablesCount.ResumeLayout(false);
            this.pnlVariablesCount.PerformLayout();
            this.gboxEvaluator.ResumeLayout(false);
            this.gboxEvaluator.PerformLayout();
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            this.gboxMinimizedFunction.ResumeLayout(false);
            this.gboxMinimizedFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizedFunction)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStripKTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDefinition;
        private System.Windows.Forms.Panel pnlVariablesCount;
        private System.Windows.Forms.RadioButton radVarsCount3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radVarsCount4;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.RadioButton radDefineByMaxterm;
        private System.Windows.Forms.RadioButton radDefineByMinterm;
        private System.Windows.Forms.GroupBox gboxEvaluator;
        private System.Windows.Forms.Label lblOutputValue;
        private System.Windows.Forms.Label lblInputValue;
        private System.Windows.Forms.TextBox txtOutputValue;
        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.LinkLabel lnkMoreOptions;
        private System.Windows.Forms.GroupBox gboxMinimizedFunction;
        private System.Windows.Forms.Label lblMinimizedFunction;
        private System.Windows.Forms.PictureBox picMinimizedFunction;
        private System.Windows.Forms.Label lbl_STATIC;
        public K_Analyzer.UserControls.ctlKarnaughTable uctlKTable;
        public System.Windows.Forms.CheckedListBox chklstOptions;
        private System.Windows.Forms.PictureBox picFunctionDefinition_Sigma;
        private System.Windows.Forms.PictureBox picFunctionDifinition_Paay;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorModesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDynamicHelpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset;
        private System.Windows.Forms.ToolStripButton toolStripButtonOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripKTable;
        private System.Windows.Forms.ToolStripMenuItem colorModesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mode1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mode2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mode3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    }
}

