namespace MyAge
{
    partial class TabSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSelectorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.optionSelectorTabControl = new System.Windows.Forms.TabControl();
            this.ageCaculatorTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorInfoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.compareMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.caculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.compareResultLabel = new System.Windows.Forms.Label();
            this.compareInfoLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ageFromNowLabel = new System.Windows.Forms.Label();
            this.lastDayOfBornYearLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstDayOfBornYearLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bornYearMiladiLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bornYearShamsiLabel = new System.Windows.Forms.Label();
            this.dateConverterTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.miladiMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.convertMiladiBtn = new System.Windows.Forms.Button();
            this.resultMiladiPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.shamsiMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.convertShamsiBtn = new System.Windows.Forms.Button();
            this.resultShamsiPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.resultShamsiLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.resultMiladiLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.optionSelectorTabControl.SuspendLayout();
            this.ageCaculatorTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.resultTableLayout.SuspendLayout();
            this.dateConverterTabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.resultMiladiPanel.SuspendLayout();
            this.resultShamsiPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.optionSelectorTabControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // optionSelectorTabControl
            // 
            this.optionSelectorTabControl.Controls.Add(this.ageCaculatorTabPage);
            this.optionSelectorTabControl.Controls.Add(this.dateConverterTabPage);
            this.optionSelectorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionSelectorTabControl.Location = new System.Drawing.Point(3, 3);
            this.optionSelectorTabControl.Name = "optionSelectorTabControl";
            this.optionSelectorTabControl.SelectedIndex = 0;
            this.optionSelectorTabControl.Size = new System.Drawing.Size(562, 237);
            this.optionSelectorTabControl.TabIndex = 0;
            // 
            // ageCaculatorTabPage
            // 
            this.ageCaculatorTabPage.Controls.Add(this.tableLayoutPanel2);
            this.ageCaculatorTabPage.Location = new System.Drawing.Point(4, 22);
            this.ageCaculatorTabPage.Name = "ageCaculatorTabPage";
            this.ageCaculatorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ageCaculatorTabPage.Size = new System.Drawing.Size(554, 211);
            this.ageCaculatorTabPage.TabIndex = 0;
            this.ageCaculatorTabPage.Text = "Tazkira Age Caculator";
            this.ageCaculatorTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0365F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.9635F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.resultPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 205);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.40816F));
            this.tableLayoutPanel3.Controls.Add(this.ageTextbox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.yearTextbox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.errorInfoLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.compareMaskedTextbox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.compareBtn, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 199);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextbox.Location = new System.Drawing.Point(58, 3);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(125, 22);
            this.ageTextbox.TabIndex = 1;
            this.ageTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearTextbox
            // 
            this.yearTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextbox.Location = new System.Drawing.Point(58, 33);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(125, 22);
            this.yearTextbox.TabIndex = 3;
            this.yearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorInfoLabel
            // 
            this.errorInfoLabel.AutoSize = true;
            this.errorInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.errorInfoLabel.Location = new System.Drawing.Point(58, 90);
            this.errorInfoLabel.Name = "errorInfoLabel";
            this.errorInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.errorInfoLabel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Compare";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compareMaskedTextbox
            // 
            this.compareMaskedTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareMaskedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareMaskedTextbox.Location = new System.Drawing.Point(58, 123);
            this.compareMaskedTextbox.Mask = "00.00.0000";
            this.compareMaskedTextbox.Name = "compareMaskedTextbox";
            this.compareMaskedTextbox.Size = new System.Drawing.Size(125, 22);
            this.compareMaskedTextbox.TabIndex = 6;
            this.compareMaskedTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compareMaskedTextbox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "dd.mm.yyyy (Miladi)";
            // 
            // compareBtn
            // 
            this.compareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compareBtn.Location = new System.Drawing.Point(108, 173);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(75, 23);
            this.compareBtn.TabIndex = 9;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.caculateBtn);
            this.flowLayoutPanel1.Controls.Add(this.resetBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(55, 60);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 30);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // caculateBtn
            // 
            this.caculateBtn.Location = new System.Drawing.Point(63, 3);
            this.caculateBtn.Name = "caculateBtn";
            this.caculateBtn.Size = new System.Drawing.Size(65, 24);
            this.caculateBtn.TabIndex = 11;
            this.caculateBtn.Text = "Caculate";
            this.caculateBtn.UseVisualStyleBackColor = true;
            this.caculateBtn.Click += new System.EventHandler(this.caculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(3, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(54, 24);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPanel.Controls.Add(this.resultTableLayout);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(197, 5);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(5);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(346, 195);
            this.resultPanel.TabIndex = 1;
            // 
            // resultTableLayout
            // 
            this.resultTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.resultTableLayout.ColumnCount = 2;
            this.resultTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.58912F));
            this.resultTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.41088F));
            this.resultTableLayout.Controls.Add(this.compareResultLabel, 1, 5);
            this.resultTableLayout.Controls.Add(this.compareInfoLabel, 0, 5);
            this.resultTableLayout.Controls.Add(this.label8, 0, 4);
            this.resultTableLayout.Controls.Add(this.ageFromNowLabel, 0, 4);
            this.resultTableLayout.Controls.Add(this.lastDayOfBornYearLabel, 1, 3);
            this.resultTableLayout.Controls.Add(this.label6, 0, 3);
            this.resultTableLayout.Controls.Add(this.firstDayOfBornYearLabel, 1, 2);
            this.resultTableLayout.Controls.Add(this.label5, 0, 2);
            this.resultTableLayout.Controls.Add(this.bornYearMiladiLabel, 1, 1);
            this.resultTableLayout.Controls.Add(this.label4, 0, 1);
            this.resultTableLayout.Controls.Add(this.label3, 0, 0);
            this.resultTableLayout.Controls.Add(this.bornYearShamsiLabel, 1, 0);
            this.resultTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTableLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTableLayout.Location = new System.Drawing.Point(0, 0);
            this.resultTableLayout.Name = "resultTableLayout";
            this.resultTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.resultTableLayout.RowCount = 6;
            this.resultTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.resultTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.resultTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.resultTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.resultTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.resultTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.resultTableLayout.Size = new System.Drawing.Size(344, 192);
            this.resultTableLayout.TabIndex = 0;
            this.resultTableLayout.Visible = false;
            // 
            // compareResultLabel
            // 
            this.compareResultLabel.AutoSize = true;
            this.compareResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareResultLabel.Location = new System.Drawing.Point(194, 158);
            this.compareResultLabel.Name = "compareResultLabel";
            this.compareResultLabel.Size = new System.Drawing.Size(144, 31);
            this.compareResultLabel.TabIndex = 11;
            this.compareResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compareInfoLabel
            // 
            this.compareInfoLabel.AutoSize = true;
            this.compareInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareInfoLabel.Location = new System.Drawing.Point(6, 158);
            this.compareInfoLabel.Name = "compareInfoLabel";
            this.compareInfoLabel.Size = new System.Drawing.Size(181, 31);
            this.compareInfoLabel.TabIndex = 10;
            this.compareInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "Age in this year:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ageFromNowLabel
            // 
            this.ageFromNowLabel.AutoSize = true;
            this.ageFromNowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageFromNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageFromNowLabel.Location = new System.Drawing.Point(194, 127);
            this.ageFromNowLabel.Name = "ageFromNowLabel";
            this.ageFromNowLabel.Size = new System.Drawing.Size(144, 30);
            this.ageFromNowLabel.TabIndex = 8;
            this.ageFromNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastDayOfBornYearLabel
            // 
            this.lastDayOfBornYearLabel.AutoSize = true;
            this.lastDayOfBornYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastDayOfBornYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDayOfBornYearLabel.Location = new System.Drawing.Point(194, 96);
            this.lastDayOfBornYearLabel.Name = "lastDayOfBornYearLabel";
            this.lastDayOfBornYearLabel.Size = new System.Drawing.Size(144, 30);
            this.lastDayOfBornYearLabel.TabIndex = 7;
            this.lastDayOfBornYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last day of born year:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstDayOfBornYearLabel
            // 
            this.firstDayOfBornYearLabel.AutoSize = true;
            this.firstDayOfBornYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstDayOfBornYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDayOfBornYearLabel.Location = new System.Drawing.Point(194, 65);
            this.firstDayOfBornYearLabel.Name = "firstDayOfBornYearLabel";
            this.firstDayOfBornYearLabel.Size = new System.Drawing.Size(144, 30);
            this.firstDayOfBornYearLabel.TabIndex = 5;
            this.firstDayOfBornYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "First day of born year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bornYearMiladiLabel
            // 
            this.bornYearMiladiLabel.AutoSize = true;
            this.bornYearMiladiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bornYearMiladiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornYearMiladiLabel.Location = new System.Drawing.Point(194, 34);
            this.bornYearMiladiLabel.Name = "bornYearMiladiLabel";
            this.bornYearMiladiLabel.Size = new System.Drawing.Size(144, 30);
            this.bornYearMiladiLabel.TabIndex = 3;
            this.bornYearMiladiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Born year Miladi Calender:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Born year Shamsi Calender:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bornYearShamsiLabel
            // 
            this.bornYearShamsiLabel.AutoSize = true;
            this.bornYearShamsiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bornYearShamsiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornYearShamsiLabel.Location = new System.Drawing.Point(194, 3);
            this.bornYearShamsiLabel.Name = "bornYearShamsiLabel";
            this.bornYearShamsiLabel.Size = new System.Drawing.Size(144, 30);
            this.bornYearShamsiLabel.TabIndex = 1;
            this.bornYearShamsiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateConverterTabPage
            // 
            this.dateConverterTabPage.Controls.Add(this.tableLayoutPanel4);
            this.dateConverterTabPage.Location = new System.Drawing.Point(4, 22);
            this.dateConverterTabPage.Name = "dateConverterTabPage";
            this.dateConverterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dateConverterTabPage.Size = new System.Drawing.Size(554, 211);
            this.dateConverterTabPage.TabIndex = 1;
            this.dateConverterTabPage.Text = "Farsi/Dari Date Converter";
            this.dateConverterTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.resultShamsiPanel, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.shamsiMaskedText, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.miladiMaskedText, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.convertMiladiBtn, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.resultMiladiPanel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.convertShamsiBtn, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(548, 205);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 30);
            this.label10.TabIndex = 6;
            this.label10.Text = "Gregorian (Miladi) date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miladiMaskedText
            // 
            this.miladiMaskedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miladiMaskedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miladiMaskedText.Location = new System.Drawing.Point(3, 33);
            this.miladiMaskedText.Mask = "00/00/0000";
            this.miladiMaskedText.Name = "miladiMaskedText";
            this.miladiMaskedText.Size = new System.Drawing.Size(268, 24);
            this.miladiMaskedText.TabIndex = 3;
            this.miladiMaskedText.ValidatingType = typeof(System.DateTime);
            this.miladiMaskedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miladiMaskedText_KeyPress);
            // 
            // convertMiladiBtn
            // 
            this.convertMiladiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertMiladiBtn.Location = new System.Drawing.Point(3, 63);
            this.convertMiladiBtn.Name = "convertMiladiBtn";
            this.convertMiladiBtn.Size = new System.Drawing.Size(83, 28);
            this.convertMiladiBtn.TabIndex = 4;
            this.convertMiladiBtn.Text = "Convert";
            this.convertMiladiBtn.UseVisualStyleBackColor = true;
            this.convertMiladiBtn.Click += new System.EventHandler(this.convertMiladiBtn_Click);
            // 
            // resultMiladiPanel
            // 
            this.resultMiladiPanel.BackColor = System.Drawing.Color.White;
            this.resultMiladiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultMiladiPanel.Controls.Add(this.tableLayoutPanel6);
            this.resultMiladiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultMiladiPanel.Location = new System.Drawing.Point(3, 97);
            this.resultMiladiPanel.Name = "resultMiladiPanel";
            this.resultMiladiPanel.Size = new System.Drawing.Size(268, 105);
            this.resultMiladiPanel.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Bahij Helvetica Neue 55 Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(277, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(268, 30);
            this.label11.TabIndex = 5;
            this.label11.Text = "تاریخ شمسی";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shamsiMaskedText
            // 
            this.shamsiMaskedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shamsiMaskedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shamsiMaskedText.Location = new System.Drawing.Point(277, 33);
            this.shamsiMaskedText.Mask = "00.00.0000";
            this.shamsiMaskedText.Name = "shamsiMaskedText";
            this.shamsiMaskedText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shamsiMaskedText.Size = new System.Drawing.Size(268, 24);
            this.shamsiMaskedText.TabIndex = 1;
            this.shamsiMaskedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shamsiMaskedText_KeyPress);
            // 
            // convertShamsiBtn
            // 
            this.convertShamsiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.convertShamsiBtn.Font = new System.Drawing.Font("Bahij Helvetica Neue 55 Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertShamsiBtn.Location = new System.Drawing.Point(458, 63);
            this.convertShamsiBtn.Name = "convertShamsiBtn";
            this.convertShamsiBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.convertShamsiBtn.Size = new System.Drawing.Size(87, 28);
            this.convertShamsiBtn.TabIndex = 2;
            this.convertShamsiBtn.Text = "تبدیل";
            this.convertShamsiBtn.UseVisualStyleBackColor = true;
            this.convertShamsiBtn.Click += new System.EventHandler(this.convertShamsiBtn_Click);
            // 
            // resultShamsiPanel
            // 
            this.resultShamsiPanel.BackColor = System.Drawing.Color.White;
            this.resultShamsiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultShamsiPanel.Controls.Add(this.tableLayoutPanel5);
            this.resultShamsiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultShamsiPanel.Location = new System.Drawing.Point(277, 97);
            this.resultShamsiPanel.Name = "resultShamsiPanel";
            this.resultShamsiPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultShamsiPanel.Size = new System.Drawing.Size(268, 105);
            this.resultShamsiPanel.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.resultShamsiLbl, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(266, 103);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // resultShamsiLbl
            // 
            this.resultShamsiLbl.AutoSize = true;
            this.resultShamsiLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultShamsiLbl.Enabled = false;
            this.resultShamsiLbl.Font = new System.Drawing.Font("Bahij Helvetica Neue 55 Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.resultShamsiLbl.Location = new System.Drawing.Point(3, 0);
            this.resultShamsiLbl.Name = "resultShamsiLbl";
            this.resultShamsiLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultShamsiLbl.Size = new System.Drawing.Size(260, 103);
            this.resultShamsiLbl.TabIndex = 6;
            this.resultShamsiLbl.Text = "نتیجه:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.resultMiladiLbl, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(266, 103);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // resultMiladiLbl
            // 
            this.resultMiladiLbl.AutoSize = true;
            this.resultMiladiLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultMiladiLbl.Enabled = false;
            this.resultMiladiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMiladiLbl.Location = new System.Drawing.Point(3, 0);
            this.resultMiladiLbl.Name = "resultMiladiLbl";
            this.resultMiladiLbl.Padding = new System.Windows.Forms.Padding(3);
            this.resultMiladiLbl.Size = new System.Drawing.Size(260, 103);
            this.resultMiladiLbl.TabIndex = 7;
            this.resultMiladiLbl.Text = "Result:";
            // 
            // TabSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 243);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TabSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Age";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.optionSelectorTabControl.ResumeLayout(false);
            this.ageCaculatorTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.resultTableLayout.ResumeLayout(false);
            this.resultTableLayout.PerformLayout();
            this.dateConverterTabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.resultMiladiPanel.ResumeLayout(false);
            this.resultShamsiPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl optionSelectorTabControl;
        private System.Windows.Forms.TabPage ageCaculatorTabPage;
        private System.Windows.Forms.TabPage dateConverterTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorInfoLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox compareMaskedTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button caculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.TableLayoutPanel resultTableLayout;
        private System.Windows.Forms.Label compareResultLabel;
        private System.Windows.Forms.Label compareInfoLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ageFromNowLabel;
        private System.Windows.Forms.Label lastDayOfBornYearLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label firstDayOfBornYearLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bornYearMiladiLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bornYearShamsiLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox miladiMaskedText;
        private System.Windows.Forms.Button convertMiladiBtn;
        private System.Windows.Forms.Panel resultMiladiPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox shamsiMaskedText;
        private System.Windows.Forms.Button convertShamsiBtn;
        private System.Windows.Forms.Panel resultShamsiPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label resultShamsiLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label resultMiladiLbl;
    }
}