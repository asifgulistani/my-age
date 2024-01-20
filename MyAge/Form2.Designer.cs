namespace MyAge
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.caculateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorInfoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.compareMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.resultTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.79245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.20755F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.51872F));
            this.tableLayoutPanel2.Controls.Add(this.ageTextbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.yearTextbox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.caculateBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.errorInfoLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.compareMaskedTextbox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.compareBtn, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 198);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextbox.Location = new System.Drawing.Point(60, 3);
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
            this.yearTextbox.Location = new System.Drawing.Point(60, 33);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(125, 22);
            this.yearTextbox.TabIndex = 3;
            this.yearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextbox_KeyPress);
            // 
            // caculateBtn
            // 
            this.caculateBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.caculateBtn.Location = new System.Drawing.Point(110, 63);
            this.caculateBtn.Name = "caculateBtn";
            this.caculateBtn.Size = new System.Drawing.Size(75, 24);
            this.caculateBtn.TabIndex = 4;
            this.caculateBtn.Text = "Caculate";
            this.caculateBtn.UseVisualStyleBackColor = true;
            this.caculateBtn.Click += new System.EventHandler(this.caculateBtn_Click);
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
            this.errorInfoLabel.Location = new System.Drawing.Point(60, 90);
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
            this.compareMaskedTextbox.Location = new System.Drawing.Point(60, 123);
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
            this.label9.Location = new System.Drawing.Point(60, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "dd.mm.yyyy (Miladi)";
            // 
            // compareBtn
            // 
            this.compareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compareBtn.Location = new System.Drawing.Point(110, 173);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(75, 23);
            this.compareBtn.TabIndex = 9;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPanel.Controls.Add(this.resultTableLayout);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(199, 5);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(5);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(326, 194);
            this.resultPanel.TabIndex = 1;
            // 
            // resultTableLayout
            // 
            this.resultTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.resultTableLayout.ColumnCount = 2;
            this.resultTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.94984F));
            this.resultTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.05016F));
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
            this.resultTableLayout.Size = new System.Drawing.Size(324, 192);
            this.resultTableLayout.TabIndex = 0;
            this.resultTableLayout.Visible = false;
            // 
            // compareResultLabel
            // 
            this.compareResultLabel.AutoSize = true;
            this.compareResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareResultLabel.Location = new System.Drawing.Point(209, 158);
            this.compareResultLabel.Name = "compareResultLabel";
            this.compareResultLabel.Size = new System.Drawing.Size(109, 31);
            this.compareResultLabel.TabIndex = 11;
            this.compareResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compareInfoLabel
            // 
            this.compareInfoLabel.AutoSize = true;
            this.compareInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareInfoLabel.Location = new System.Drawing.Point(6, 158);
            this.compareInfoLabel.Name = "compareInfoLabel";
            this.compareInfoLabel.Size = new System.Drawing.Size(196, 31);
            this.compareInfoLabel.TabIndex = 10;
            this.compareInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "Age in this year:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ageFromNowLabel
            // 
            this.ageFromNowLabel.AutoSize = true;
            this.ageFromNowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageFromNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageFromNowLabel.Location = new System.Drawing.Point(209, 127);
            this.ageFromNowLabel.Name = "ageFromNowLabel";
            this.ageFromNowLabel.Size = new System.Drawing.Size(109, 30);
            this.ageFromNowLabel.TabIndex = 8;
            this.ageFromNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastDayOfBornYearLabel
            // 
            this.lastDayOfBornYearLabel.AutoSize = true;
            this.lastDayOfBornYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastDayOfBornYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDayOfBornYearLabel.Location = new System.Drawing.Point(209, 96);
            this.lastDayOfBornYearLabel.Name = "lastDayOfBornYearLabel";
            this.lastDayOfBornYearLabel.Size = new System.Drawing.Size(109, 30);
            this.lastDayOfBornYearLabel.TabIndex = 7;
            this.lastDayOfBornYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last day of born year:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstDayOfBornYearLabel
            // 
            this.firstDayOfBornYearLabel.AutoSize = true;
            this.firstDayOfBornYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstDayOfBornYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDayOfBornYearLabel.Location = new System.Drawing.Point(209, 65);
            this.firstDayOfBornYearLabel.Name = "firstDayOfBornYearLabel";
            this.firstDayOfBornYearLabel.Size = new System.Drawing.Size(109, 30);
            this.firstDayOfBornYearLabel.TabIndex = 5;
            this.firstDayOfBornYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "First day of born year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bornYearMiladiLabel
            // 
            this.bornYearMiladiLabel.AutoSize = true;
            this.bornYearMiladiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bornYearMiladiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornYearMiladiLabel.Location = new System.Drawing.Point(209, 34);
            this.bornYearMiladiLabel.Name = "bornYearMiladiLabel";
            this.bornYearMiladiLabel.Size = new System.Drawing.Size(109, 30);
            this.bornYearMiladiLabel.TabIndex = 3;
            this.bornYearMiladiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Born year in Miladi Calender:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Born year in Shamsi Calender:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bornYearShamsiLabel
            // 
            this.bornYearShamsiLabel.AutoSize = true;
            this.bornYearShamsiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bornYearShamsiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornYearShamsiLabel.Location = new System.Drawing.Point(209, 3);
            this.bornYearShamsiLabel.Name = "bornYearShamsiLabel";
            this.bornYearShamsiLabel.Size = new System.Drawing.Size(109, 30);
            this.bornYearShamsiLabel.TabIndex = 1;
            this.bornYearShamsiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 204);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Age";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultTableLayout.ResumeLayout(false);
            this.resultTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.Button caculateBtn;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label errorInfoLabel;
        private System.Windows.Forms.TableLayoutPanel resultTableLayout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bornYearShamsiLabel;
        private System.Windows.Forms.Label bornYearMiladiLabel;
        private System.Windows.Forms.Label lastDayOfBornYearLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label firstDayOfBornYearLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ageFromNowLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox compareMaskedTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Label compareResultLabel;
        private System.Windows.Forms.Label compareInfoLabel;
    }
}