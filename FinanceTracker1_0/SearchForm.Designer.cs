namespace FinanceTracker1_0
{
    partial class SearchForm
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ListBox();
            this.intervalBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dayBox = new System.Windows.Forms.NumericUpDown();
            this.monthBox = new System.Windows.Forms.NumericUpDown();
            this.yearBox = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.mainLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Controls.Add(this.searchButton, 1, 7);
            this.mainLayout.Controls.Add(this.intervalLabel, 1, 3);
            this.mainLayout.Controls.Add(this.categoryLabel, 1, 1);
            this.mainLayout.Controls.Add(this.topLabel, 1, 0);
            this.mainLayout.Controls.Add(this.categoryBox, 1, 2);
            this.mainLayout.Controls.Add(this.intervalBox, 1, 4);
            this.mainLayout.Controls.Add(this.panel1, 1, 6);
            this.mainLayout.Controls.Add(this.panel2, 1, 5);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 8;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(480, 480);
            this.mainLayout.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.Location = new System.Drawing.Point(90, 423);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(300, 32);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.intervalLabel.Location = new System.Drawing.Point(27, 174);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(3);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(426, 51);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Interval Filter";
            this.intervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryLabel.Location = new System.Drawing.Point(27, 60);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(426, 51);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category Filter";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryLabel.Click += new System.EventHandler(this.filterCategory_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topLabel.Location = new System.Drawing.Point(27, 3);
            this.topLabel.Margin = new System.Windows.Forms.Padding(3);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(426, 51);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Search";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryBox
            // 
            this.categoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.ItemHeight = 20;
            this.categoryBox.Location = new System.Drawing.Point(27, 117);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(426, 51);
            this.categoryBox.TabIndex = 2;
            // 
            // intervalBox
            // 
            this.intervalBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intervalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.ItemHeight = 20;
            this.intervalBox.Location = new System.Drawing.Point(27, 231);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(426, 51);
            this.intervalBox.TabIndex = 4;
            this.intervalBox.SelectedIndexChanged += new System.EventHandler(this.SetValueLimits);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dayBox);
            this.panel1.Controls.Add(this.monthBox);
            this.panel1.Controls.Add(this.yearBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 343);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 55);
            this.panel1.TabIndex = 8;
            // 
            // dayBox
            // 
            this.dayBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayBox.Location = new System.Drawing.Point(4, 17);
            this.dayBox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(138, 26);
            this.dayBox.TabIndex = 8;
            this.dayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dayBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthBox
            // 
            this.monthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthBox.Location = new System.Drawing.Point(146, 17);
            this.monthBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(138, 26);
            this.monthBox.TabIndex = 7;
            this.monthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearBox
            // 
            this.yearBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yearBox.Location = new System.Drawing.Point(288, 17);
            this.yearBox.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearBox.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(138, 26);
            this.yearBox.TabIndex = 6;
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dayLabel);
            this.panel2.Controls.Add(this.monthLabel);
            this.panel2.Controls.Add(this.yearLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(25, 286);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 55);
            this.panel2.TabIndex = 9;
            // 
            // dayLabel
            // 
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayLabel.Location = new System.Drawing.Point(4, 30);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(138, 24);
            this.dayLabel.TabIndex = 7;
            this.dayLabel.Text = "DAY";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLabel
            // 
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthLabel.Location = new System.Drawing.Point(146, 30);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(3);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(138, 24);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "MONTH";
            this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monthLabel.Click += new System.EventHandler(this.ShowHideMonth);
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yearLabel.Location = new System.Drawing.Point(288, 30);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(3);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(138, 24);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "YEAR";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yearLabel.Click += new System.EventHandler(this.ShowHideYear);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.mainLayout);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ListBox categoryBox;
        private System.Windows.Forms.ListBox intervalBox;
        private System.Windows.Forms.NumericUpDown yearBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown dayBox;
        private System.Windows.Forms.NumericUpDown monthBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
    }
}