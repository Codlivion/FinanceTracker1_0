using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FinanceTracker1_0
{
    public partial class InputForm : Form
    {
        MainForm mainForm;
        string formMode;
        public bool editMode;
        public int editNum;
        Label[] modeLabels;
        string[] incomeTexts, expenseTexts;
        string connectionString => MainForm.connectionString;

        public InputForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;

            modeLabels = new Label[5] { topLabel, categoryLabel, amountLabel, detailsLabel, dateLabel };
            incomeTexts = new string[5] { "New Income", "Income Category", "Income Amount", "Income Details", "Income Date" };
            expenseTexts = new string[5] { "New Expense", "Expense Category", "Expense Amount", "Expense Details", "Expense Date" };
        }

        public InputForm(MainForm main, string mode) : this(main)
        {
            formMode = mode;
            SetMode(false);
        }

        public InputForm(MainForm main, string mode, int id) : this (main)
        {
            formMode = mode;
            editNum = id;
            SetMode(true);
        }

        public void SetMode(bool eMode)
        {
            switch (formMode)
            {
                case "income":
                    FillLabels(incomeTexts);
                    break;
                case "expense":
                    FillLabels(expenseTexts);
                    break;
                default:
                    Close();
                    break;
            }

            FillLists(mainForm.GetCategories(formMode));
            editMode = eMode;
            if (editMode)
            {
                topLabel.Text = topLabel.Text.Substring(4);
                addButton.Text = "Edit";
                deleteButton.Visible = true;
                cancelButton.Text = "Close";
            }
        }

        private void newCategory_Click(object sender, EventArgs e)
        {
            string newCategory = newCategoryBox.Text;
            newCategoryBox.Text = "";
            if (((List<KeyValuePair<string, int>>)categoryBox.DataSource).Any(item => item.Key == newCategory))
            { MessageBox.Show("Category Name is a duplicate!"); return; }
            if (newCategory == "")
            { MessageBox.Show("Category Name is invalid!"); return; }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string modeCap = formMode == "income" ? "IncomeCategory" : formMode == "expense" ? "ExpenseCategory" : "";
                string insertCmd = String.Format("INSERT INTO {0} (category_name) VALUES (@category_name)", modeCap, formMode);
                using (SqlCommand command = new SqlCommand(insertCmd, connection))
                {
                    command.Parameters.AddWithValue("@category_name", newCategory);
                    command.ExecuteNonQuery();
                }
            }
            FillLists(mainForm.GetCategories(formMode));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (amountBox.Value == 0)
            {
                MessageBox.Show("The amount wasn't specified!");
                return;
            }
            if (editMode) { FixInDB(editNum); }
            else { AddToDB(); }
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (editMode) { DeleteFromDB(editNum); }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillLabels(string[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                modeLabels[i].Text = texts[i];
            }
        }

        private void FillLists(List<KeyValuePair<string, int>> categories)
        {
            categoryBox.DataSource = categories;
            categoryBox.DisplayMember = "Key";
            categoryBox.ValueMember = "Value";
        }

        private void AddToDB()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string modeCap = formMode == "income" ? "Income" : formMode == "expense" ? "Expense" : "";
                string insertCmd = String.Format("INSERT INTO {0} ({1}_category, {1}_amount, {1}_details, {1}_date) " +
                    "VALUES (@category, @amount, @details, @date)", modeCap, formMode);
                using (SqlCommand command = new SqlCommand(insertCmd, connection))
                {
                    command.Parameters.AddWithValue("@category", categoryBox.SelectedValue);
                    command.Parameters.AddWithValue("@amount", amountBox.Value);
                    command.Parameters.AddWithValue("@details", detailsBox.Text);
                    command.Parameters.AddWithValue("@date", dateBox.Value);
                    command.ExecuteNonQuery();
                }
            }
            mainForm.UpdateStartYear();
        }

        private void FixInDB(int id) //Not implemented yet?
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string modeCap = formMode == "income" ? "Income" : formMode == "expense" ? "Expense" : "";
                string updateCmd = String.Format("UPDATE {0} SET {1}_category = @category, {1}_amount = @amount, " +
                    "{1}_details = @details, {1}_date = @date WHERE {1}_ID = @id", modeCap, formMode);
                using (SqlCommand command = new SqlCommand(updateCmd, connection))
                {
                    command.Parameters.AddWithValue("@category", categoryBox.SelectedValue);
                    command.Parameters.AddWithValue("@amount", amountBox.Value);
                    command.Parameters.AddWithValue("@details", detailsBox.Text);
                    command.Parameters.AddWithValue("@date", dateBox.Value);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteFromDB(int id) //Not implemented yet?
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string modeCap = formMode == "income" ? "Income" : formMode == "expense" ? "Expense" : "";
                string deleteCmd = String.Format("DELETE FROM {0} WHERE {1}_ID = @id", modeCap, formMode);
                using (SqlCommand command = new SqlCommand(deleteCmd, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}