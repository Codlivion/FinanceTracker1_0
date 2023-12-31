namespace FinanceTracker1_0
{
    partial class InputForm
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
            this.newCategoryBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ListBox();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.newCategoryButton = new System.Windows.Forms.Button();
            this.buttonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            this.buttonsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Controls.Add(this.newCategoryBox, 1, 2);
            this.mainLayout.Controls.Add(this.dateLabel, 1, 9);
            this.mainLayout.Controls.Add(this.detailsLabel, 1, 7);
            this.mainLayout.Controls.Add(this.amountLabel, 1, 5);
            this.mainLayout.Controls.Add(this.categoryLabel, 1, 3);
            this.mainLayout.Controls.Add(this.topLabel, 1, 0);
            this.mainLayout.Controls.Add(this.categoryBox, 1, 4);
            this.mainLayout.Controls.Add(this.amountBox, 1, 6);
            this.mainLayout.Controls.Add(this.detailsBox, 1, 8);
            this.mainLayout.Controls.Add(this.dateBox, 1, 10);
            this.mainLayout.Controls.Add(this.newCategoryButton, 1, 1);
            this.mainLayout.Controls.Add(this.buttonsFlow, 1, 11);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 12;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.Size = new System.Drawing.Size(480, 480);
            this.mainLayout.TabIndex = 0;
            // 
            // newCategoryBox
            // 
            this.newCategoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newCategoryBox.Location = new System.Drawing.Point(27, 79);
            this.newCategoryBox.Name = "newCategoryBox";
            this.newCategoryBox.Size = new System.Drawing.Size(426, 26);
            this.newCategoryBox.TabIndex = 11;
            this.newCategoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.Location = new System.Drawing.Point(27, 372);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(426, 22);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detailsLabel.Location = new System.Drawing.Point(27, 268);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(426, 22);
            this.detailsLabel.TabIndex = 8;
            this.detailsLabel.Text = "Details";
            this.detailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amountLabel.Location = new System.Drawing.Point(27, 202);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(3);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(426, 22);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryLabel.Location = new System.Drawing.Point(27, 117);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(426, 22);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topLabel.Location = new System.Drawing.Point(27, 3);
            this.topLabel.Margin = new System.Windows.Forms.Padding(3);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(426, 32);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "NEW";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryBox
            // 
            this.categoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.ItemHeight = 20;
            this.categoryBox.Location = new System.Drawing.Point(27, 145);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(426, 51);
            this.categoryBox.TabIndex = 1;
            // 
            // amountBox
            // 
            this.amountBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amountBox.Location = new System.Drawing.Point(27, 230);
            this.amountBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(426, 32);
            this.amountBox.TabIndex = 2;
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailsBox
            // 
            this.detailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detailsBox.Location = new System.Drawing.Point(27, 296);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(426, 70);
            this.detailsBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBox.Location = new System.Drawing.Point(27, 400);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(426, 26);
            this.dateBox.TabIndex = 4;
            // 
            // newCategoryButton
            // 
            this.newCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newCategoryButton.Location = new System.Drawing.Point(27, 41);
            this.newCategoryButton.Name = "newCategoryButton";
            this.newCategoryButton.Size = new System.Drawing.Size(426, 32);
            this.newCategoryButton.TabIndex = 6;
            this.newCategoryButton.Text = "Add New Category";
            this.newCategoryButton.UseVisualStyleBackColor = true;
            this.newCategoryButton.Click += new System.EventHandler(this.newCategory_Click);
            // 
            // buttonsFlow
            // 
            this.buttonsFlow.Controls.Add(this.addButton);
            this.buttonsFlow.Controls.Add(this.deleteButton);
            this.buttonsFlow.Controls.Add(this.cancelButton);
            this.buttonsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlow.Location = new System.Drawing.Point(27, 438);
            this.buttonsFlow.Name = "buttonsFlow";
            this.buttonsFlow.Size = new System.Drawing.Size(426, 39);
            this.buttonsFlow.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.Location = new System.Drawing.Point(145, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 32);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.Location = new System.Drawing.Point(287, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 32);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.mainLayout);
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            this.buttonsFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.ListBox categoryBox;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button newCategoryButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlow;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox newCategoryBox;
    }
}