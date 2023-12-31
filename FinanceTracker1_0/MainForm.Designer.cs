namespace FinanceTracker1_0
{
    partial class MainForm
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
            this.newExpenseButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.newIncomeButton = new System.Windows.Forms.Button();
            this.buttonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.sIncomeButton = new System.Windows.Forms.Button();
            this.sExpenseButton = new System.Windows.Forms.Button();
            this.sBalanceButton = new System.Windows.Forms.Button();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.mainLayout.SuspendLayout();
            this.buttonsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 7;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Controls.Add(this.newExpenseButton, 4, 1);
            this.mainLayout.Controls.Add(this.topLabel, 2, 0);
            this.mainLayout.Controls.Add(this.newIncomeButton, 2, 1);
            this.mainLayout.Controls.Add(this.buttonsFlow, 2, 5);
            this.mainLayout.Controls.Add(this.outputPanel, 2, 6);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 8;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Size = new System.Drawing.Size(800, 640);
            this.mainLayout.TabIndex = 0;
            // 
            // newExpenseButton
            // 
            this.newExpenseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newExpenseButton.Location = new System.Drawing.Point(443, 35);
            this.newExpenseButton.Name = "newExpenseButton";
            this.newExpenseButton.Size = new System.Drawing.Size(274, 32);
            this.newExpenseButton.TabIndex = 2;
            this.newExpenseButton.Tag = "expense";
            this.newExpenseButton.Text = "New Expense";
            this.newExpenseButton.UseVisualStyleBackColor = true;
            this.newExpenseButton.Click += new System.EventHandler(this.newEntryButton_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.mainLayout.SetColumnSpan(this.topLabel, 3);
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topLabel.Location = new System.Drawing.Point(83, 3);
            this.topLabel.Margin = new System.Windows.Forms.Padding(3);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(634, 26);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "FINANCE TRACKER";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newIncomeButton
            // 
            this.newIncomeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newIncomeButton.Location = new System.Drawing.Point(83, 35);
            this.newIncomeButton.Name = "newIncomeButton";
            this.newIncomeButton.Size = new System.Drawing.Size(274, 32);
            this.newIncomeButton.TabIndex = 1;
            this.newIncomeButton.Tag = "income";
            this.newIncomeButton.Text = "New Income";
            this.newIncomeButton.UseVisualStyleBackColor = true;
            this.newIncomeButton.Click += new System.EventHandler(this.newEntryButton_Click);
            // 
            // buttonsFlow
            // 
            this.mainLayout.SetColumnSpan(this.buttonsFlow, 3);
            this.buttonsFlow.Controls.Add(this.sIncomeButton);
            this.buttonsFlow.Controls.Add(this.sExpenseButton);
            this.buttonsFlow.Controls.Add(this.sBalanceButton);
            this.buttonsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlow.Location = new System.Drawing.Point(83, 187);
            this.buttonsFlow.Name = "buttonsFlow";
            this.buttonsFlow.Size = new System.Drawing.Size(634, 32);
            this.buttonsFlow.TabIndex = 3;
            // 
            // sIncomeButton
            // 
            this.sIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sIncomeButton.Location = new System.Drawing.Point(90, 3);
            this.sIncomeButton.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.sIncomeButton.Name = "sIncomeButton";
            this.sIncomeButton.Size = new System.Drawing.Size(150, 30);
            this.sIncomeButton.TabIndex = 0;
            this.sIncomeButton.Tag = "income";
            this.sIncomeButton.Text = "Search Income";
            this.sIncomeButton.UseVisualStyleBackColor = true;
            this.sIncomeButton.Click += new System.EventHandler(this.searchButton_CLick);
            // 
            // sExpenseButton
            // 
            this.sExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sExpenseButton.Location = new System.Drawing.Point(246, 3);
            this.sExpenseButton.Name = "sExpenseButton";
            this.sExpenseButton.Size = new System.Drawing.Size(150, 30);
            this.sExpenseButton.TabIndex = 1;
            this.sExpenseButton.Tag = "expense";
            this.sExpenseButton.Text = "Search Expense";
            this.sExpenseButton.UseVisualStyleBackColor = true;
            this.sExpenseButton.Click += new System.EventHandler(this.searchButton_CLick);
            // 
            // sBalanceButton
            // 
            this.sBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sBalanceButton.Location = new System.Drawing.Point(402, 3);
            this.sBalanceButton.Name = "sBalanceButton";
            this.sBalanceButton.Size = new System.Drawing.Size(150, 30);
            this.sBalanceButton.TabIndex = 2;
            this.sBalanceButton.Tag = "balance";
            this.sBalanceButton.Text = "Search Balance";
            this.sBalanceButton.UseVisualStyleBackColor = true;
            this.sBalanceButton.Click += new System.EventHandler(this.searchButton_CLick);
            // 
            // outputPanel
            // 
            this.outputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLayout.SetColumnSpan(this.outputPanel, 3);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(83, 225);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(634, 378);
            this.outputPanel.TabIndex = 4;
            this.outputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawOutput);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.mainLayout);
            this.Name = "MainForm";
            this.Text = "Finance Tracker";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.buttonsFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button newExpenseButton;
        private System.Windows.Forms.Button newIncomeButton;
        private System.Windows.Forms.Button sIncomeButton;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlow;
        private System.Windows.Forms.Button sExpenseButton;
        private System.Windows.Forms.Button sBalanceButton;
        private System.Windows.Forms.Panel outputPanel;
    }
}

