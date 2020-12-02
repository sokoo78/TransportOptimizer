namespace TransportOptimizer
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelNumberOfCustomers = new System.Windows.Forms.Label();
            this.LabelNumberOfSellers = new System.Windows.Forms.Label();
            this.numUpDownSupplierCount = new System.Windows.Forms.NumericUpDown();
            this.numUpDownConsumerCount = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewProblem = new System.Windows.Forms.DataGridView();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.dataGridViewSolution = new System.Windows.Forms.DataGridView();
            this.panelControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelSolutionBackground = new System.Windows.Forms.Panel();
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.panelProblemGrid = new System.Windows.Forms.Panel();
            this.labelBlock = new System.Windows.Forms.Label();
            this.richTextBoxProblem = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSolution = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSupplierCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownConsumerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolution)).BeginInit();
            this.panelControls.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelSolutionBackground.SuspendLayout();
            this.panelProblemGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumberOfCustomers
            // 
            this.labelNumberOfCustomers.AutoSize = true;
            this.labelNumberOfCustomers.Location = new System.Drawing.Point(3, 12);
            this.labelNumberOfCustomers.Name = "labelNumberOfCustomers";
            this.labelNumberOfCustomers.Size = new System.Drawing.Size(74, 13);
            this.labelNumberOfCustomers.TabIndex = 0;
            this.labelNumberOfCustomers.Text = "Vevők száma:";
            // 
            // LabelNumberOfSellers
            // 
            this.LabelNumberOfSellers.AutoSize = true;
            this.LabelNumberOfSellers.Location = new System.Drawing.Point(1, 39);
            this.LabelNumberOfSellers.Name = "LabelNumberOfSellers";
            this.LabelNumberOfSellers.Size = new System.Drawing.Size(76, 13);
            this.LabelNumberOfSellers.TabIndex = 1;
            this.LabelNumberOfSellers.Text = "Eladók száma:";
            // 
            // numUpDownSupplierCount
            // 
            this.numUpDownSupplierCount.Location = new System.Drawing.Point(83, 36);
            this.numUpDownSupplierCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownSupplierCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownSupplierCount.Name = "numUpDownSupplierCount";
            this.numUpDownSupplierCount.Size = new System.Drawing.Size(41, 20);
            this.numUpDownSupplierCount.TabIndex = 2;
            this.numUpDownSupplierCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownSupplierCount.ValueChanged += new System.EventHandler(this.NumUpDownShopCount_ValueChanged);
            // 
            // numUpDownConsumerCount
            // 
            this.numUpDownConsumerCount.Location = new System.Drawing.Point(83, 10);
            this.numUpDownConsumerCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownConsumerCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownConsumerCount.Name = "numUpDownConsumerCount";
            this.numUpDownConsumerCount.Size = new System.Drawing.Size(41, 20);
            this.numUpDownConsumerCount.TabIndex = 3;
            this.numUpDownConsumerCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownConsumerCount.ValueChanged += new System.EventHandler(this.NumUpDownCustomerCount_ValueChanged);
            // 
            // dataGridViewProblem
            // 
            this.dataGridViewProblem.AllowUserToAddRows = false;
            this.dataGridViewProblem.AllowUserToDeleteRows = false;
            this.dataGridViewProblem.AllowUserToResizeColumns = false;
            this.dataGridViewProblem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewProblem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProblem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProblem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProblem.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProblem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProblem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProblem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProblem.Location = new System.Drawing.Point(3, 109);
            this.dataGridViewProblem.Name = "dataGridViewProblem";
            this.dataGridViewProblem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProblem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProblem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(11)))));
            this.dataGridViewProblem.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProblem.Size = new System.Drawing.Size(461, 301);
            this.dataGridViewProblem.TabIndex = 4;
            this.dataGridViewProblem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewProblem_CellFormatting);
            this.dataGridViewProblem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProblem_CellValueChanged);
            this.dataGridViewProblem.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridViewProblem_ColumnAdded);
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSolve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSolve.Location = new System.Drawing.Point(130, 10);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(80, 47);
            this.buttonSolve.TabIndex = 5;
            this.buttonSolve.Text = "Megoldás";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.ButtonSolve_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonResetForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonResetForm.Location = new System.Drawing.Point(216, 10);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(80, 47);
            this.buttonResetForm.TabIndex = 6;
            this.buttonResetForm.Text = "Új feladat";
            this.buttonResetForm.UseVisualStyleBackColor = false;
            this.buttonResetForm.Click += new System.EventHandler(this.ButtonResetForm_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(25, 46);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(67, 13);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Összköltség:";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(3, 17);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(89, 13);
            this.labelSolution.TabIndex = 6;
            this.labelSolution.Text = "Megoldás jellege:";
            // 
            // dataGridViewSolution
            // 
            this.dataGridViewSolution.AllowUserToAddRows = false;
            this.dataGridViewSolution.AllowUserToDeleteRows = false;
            this.dataGridViewSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSolution.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSolution.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSolution.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSolution.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSolution.Location = new System.Drawing.Point(470, 109);
            this.dataGridViewSolution.Name = "dataGridViewSolution";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSolution.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSolution.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSolution.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSolution.Size = new System.Drawing.Size(462, 301);
            this.dataGridViewSolution.TabIndex = 5;
            this.dataGridViewSolution.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewSolution_CellFormatting);
            this.dataGridViewSolution.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSolution_CellValueChanged);
            this.dataGridViewSolution.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridViewSolution_ColumnAdded);
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.Controls.Add(this.buttonResetForm);
            this.panelControls.Controls.Add(this.labelNumberOfCustomers);
            this.panelControls.Controls.Add(this.LabelNumberOfSellers);
            this.panelControls.Controls.Add(this.numUpDownSupplierCount);
            this.panelControls.Controls.Add(this.buttonSolve);
            this.panelControls.Controls.Add(this.numUpDownConsumerCount);
            this.panelControls.Location = new System.Drawing.Point(3, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(461, 74);
            this.panelControls.TabIndex = 9;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.panelResults, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panelControls, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelProblemGrid, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.richTextBoxSolution, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewSolution, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewProblem, 0, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(935, 410);
            this.tableLayoutPanel.TabIndex = 13;
            // 
            // panelResults
            // 
            this.panelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResults.Controls.Add(this.buttonHelp);
            this.panelResults.Controls.Add(this.labelError);
            this.panelResults.Controls.Add(this.panelSolutionBackground);
            this.panelResults.Controls.Add(this.textBoxCost);
            this.panelResults.Controls.Add(this.labelCost);
            this.panelResults.Controls.Add(this.labelSolution);
            this.panelResults.Location = new System.Drawing.Point(470, 3);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(462, 74);
            this.panelResults.TabIndex = 14;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp.Location = new System.Drawing.Point(429, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(247, 17);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 11;
            // 
            // panelSolutionBackground
            // 
            this.panelSolutionBackground.Controls.Add(this.textBoxSolution);
            this.panelSolutionBackground.Location = new System.Drawing.Point(98, 8);
            this.panelSolutionBackground.Name = "panelSolutionBackground";
            this.panelSolutionBackground.Size = new System.Drawing.Size(132, 33);
            this.panelSolutionBackground.TabIndex = 10;
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSolution.CausesValidation = false;
            this.textBoxSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSolution.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSolution.Location = new System.Drawing.Point(15, 10);
            this.textBoxSolution.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSolution.MaxLength = 50;
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.ReadOnly = true;
            this.textBoxSolution.Size = new System.Drawing.Size(101, 13);
            this.textBoxSolution.TabIndex = 8;
            this.textBoxSolution.TabStop = false;
            this.textBoxSolution.BackColorChanged += new System.EventHandler(this.TextBoxSolution_BackColorChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCost.CausesValidation = false;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCost.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCost.Location = new System.Drawing.Point(98, 46);
            this.textBoxCost.MaxLength = 50;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(146, 13);
            this.textBoxCost.TabIndex = 9;
            this.textBoxCost.TabStop = false;
            // 
            // panelProblemGrid
            // 
            this.panelProblemGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProblemGrid.Controls.Add(this.labelBlock);
            this.panelProblemGrid.Controls.Add(this.richTextBoxProblem);
            this.panelProblemGrid.Location = new System.Drawing.Point(3, 83);
            this.panelProblemGrid.Name = "panelProblemGrid";
            this.panelProblemGrid.Size = new System.Drawing.Size(461, 20);
            this.panelProblemGrid.TabIndex = 12;
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Location = new System.Drawing.Point(151, 6);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(232, 13);
            this.labelBlock.TabIndex = 7;
            this.labelBlock.Text = "Transzport blokkolásához írj a mezőbe egy x-et!";
            // 
            // richTextBoxProblem
            // 
            this.richTextBoxProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProblem.CausesValidation = false;
            this.richTextBoxProblem.DetectUrls = false;
            this.richTextBoxProblem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxProblem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxProblem.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxProblem.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxProblem.MaxLength = 10;
            this.richTextBoxProblem.Multiline = false;
            this.richTextBoxProblem.Name = "richTextBoxProblem";
            this.richTextBoxProblem.ReadOnly = true;
            this.richTextBoxProblem.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxProblem.ShortcutsEnabled = false;
            this.richTextBoxProblem.Size = new System.Drawing.Size(461, 20);
            this.richTextBoxProblem.TabIndex = 0;
            this.richTextBoxProblem.TabStop = false;
            this.richTextBoxProblem.Text = "Feladat";
            this.richTextBoxProblem.WordWrap = false;
            // 
            // richTextBoxSolution
            // 
            this.richTextBoxSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxSolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSolution.CausesValidation = false;
            this.richTextBoxSolution.DetectUrls = false;
            this.richTextBoxSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxSolution.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxSolution.Location = new System.Drawing.Point(467, 80);
            this.richTextBoxSolution.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxSolution.MaxLength = 10;
            this.richTextBoxSolution.Multiline = false;
            this.richTextBoxSolution.Name = "richTextBoxSolution";
            this.richTextBoxSolution.ReadOnly = true;
            this.richTextBoxSolution.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxSolution.ShortcutsEnabled = false;
            this.richTextBoxSolution.Size = new System.Drawing.Size(392, 26);
            this.richTextBoxSolution.TabIndex = 1;
            this.richTextBoxSolution.TabStop = false;
            this.richTextBoxSolution.Text = "Megoldás";
            this.richTextBoxSolution.WordWrap = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(954, 431);
            this.Controls.Add(this.tableLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(805, 300);
            this.Name = "FormMain";
            this.Text = "Transport";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSupplierCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownConsumerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolution)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelSolutionBackground.ResumeLayout(false);
            this.panelSolutionBackground.PerformLayout();
            this.panelProblemGrid.ResumeLayout(false);
            this.panelProblemGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfCustomers;
        private System.Windows.Forms.Label LabelNumberOfSellers;
        private System.Windows.Forms.NumericUpDown numUpDownSupplierCount;
        private System.Windows.Forms.NumericUpDown numUpDownConsumerCount;
        private System.Windows.Forms.DataGridView dataGridViewProblem;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.DataGridView dataGridViewSolution;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelProblemGrid;
        private System.Windows.Forms.RichTextBox richTextBoxProblem;
        private System.Windows.Forms.RichTextBox richTextBoxSolution;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxSolution;
        private System.Windows.Forms.Panel panelSolutionBackground;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonHelp;
    }
}

