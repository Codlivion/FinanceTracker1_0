using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinanceTracker1_0
{
    public partial class MainForm : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["FinanceTrackerDB"].ConnectionString;

        int startYear;
        Font stdFont = new Font("Arial", 12);
        int scrollPos = 0;
        int lineLimit = 16;

        List<string> outputText = new List<string>();
        List<KeyValuePair<string, string>> timePeriods;
        List<KeyValuePair<string, string>> timeIntervals;

        public MainForm()
        {
            InitializeComponent();
            startYear = GetStartYear();
            outputPanel.MouseWheel += OutputWheel;

            timePeriods = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("All", "all"),
                new KeyValuePair<string, string>("Yearly", "yearly"),
                new KeyValuePair<string, string>("Quarterly", "quarterly"),
                new KeyValuePair<string, string>("Monthly", "monthly"),
                new KeyValuePair<string, string>("Weekly", "weekly"),
                new KeyValuePair<string, string>("Daily", "daily")
            };

            timeIntervals = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("All", "all"),
                new KeyValuePair<string, string>("Year", "year"),
                new KeyValuePair<string, string>("Month", "month"),
                new KeyValuePair<string, string>("Day", "day")
            };
        }

        public void DrawOutput(object sender, PaintEventArgs e)
        {
            if (outputText.Count == 0) return;

            int endIndex = Math.Min(scrollPos + lineLimit, outputText.Count);
            for (int i = scrollPos; i < endIndex; i++)
            {
                int iPos = i - scrollPos;
                e.Graphics.DrawString(outputText[i], stdFont, Brushes.Black, 10, iPos * 22 + 10);
            }
        }

        public void OutputWheel(object sender, MouseEventArgs e)
        {
            scrollPos -= e.Delta > 0 ? 1 : e.Delta < 0 ? -1 : 0;
            if (scrollPos < 0) scrollPos = 0;
            if (outputText.Count >= lineLimit)
            {
                if (scrollPos > outputText.Count - lineLimit) scrollPos = outputText.Count - lineLimit;
            }
            else scrollPos = 0;
            outputPanel.Invalidate();
        }

        public void ReadIncomeOrExpense(string mode, string query)
        {
            int totalAmount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            totalAmount += reader.GetInt32(0);
                            string txtAmount = Convert.ToString(reader.GetInt32(0));
                            string txtDetails = reader.GetString(1);
                            DateTime dateTime = reader.GetDateTime(2);
                            string txtDate = dateTime.ToString("dd-MM-yyyy");
                            string txtCategory = reader.GetString(3);
                            outputText.Add(txtCategory + " | " + txtAmount + " | " + txtDetails + " | " + txtDate);
                        }
                        string modeCap = mode == "income" ? "Income" : mode == "expense" ? "Expense" : "";
                        outputText.Add(String.Format("Total {0}: " + totalAmount, modeCap));
                    }
                }
            }
        }

        public void ReadIncomeOrExpense(string mode, string query, int cID, string cName)
        {
            int totalAmount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@category_ID", cID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            totalAmount += reader.GetInt32(0);
                            string txtAmount = Convert.ToString(reader.GetInt32(0));
                            string txtDetails = reader.GetString(1);
                            DateTime dateTime = reader.GetDateTime(2);
                            string txtDate = dateTime.ToString("dd-MM-yyyy");
                            outputText.Add(cName + " | " + txtAmount + " | " + txtDetails + " | " + txtDate);
                        }
                        string modeCap = mode == "income" ? "Income" : mode == "expense" ? "Expense" : "";
                        outputText.Add(String.Format("Total {0} {1}: " + totalAmount, cName, modeCap));
                    }
                }
            }
        }

        public void ViewIncomeOrExpense(string mode, string interval, int year, int month, int day, int cID = -1, string cName = "")
        {
            outputText.Clear();
            scrollPos = 0;
            string modeCap = mode == "income" ? "Income" : mode == "expense" ? "Expense" : "";
            string query, conj;
            if (cID == -1)
            {
                query = String.Format("SELECT {0}.{1}_amount, {0}.{1}_details, {0}.{1}_date, {0}Category.category_name " +
                    "FROM {0} JOIN {0}Category ON {0}.{1}_category = {0}Category.category_ID", modeCap, mode);
                conj = "WHERE";
            }
            else
            {
                query = String.Format("SELECT {0}.{1}_amount, {0}.{1}_details, {0}.{1}_date " +
                    "FROM {0} WHERE {0}.{1}_category = @category_ID", modeCap, mode);
                conj = "AND";
            }

            switch (interval)
            {
                case "all":
                    if (cID == -1) ReadIncomeOrExpense(mode, query);
                    else ReadIncomeOrExpense(mode, query, cID, cName);
                    break;
                case "year":
                    query += String.Format(" {0} DATEPART(YEAR, {1}_date) = {2}", conj, mode, year);
                    if (cID == -1) ReadIncomeOrExpense(mode, query);
                    else ReadIncomeOrExpense(mode, query, cID, cName);
                    break;
                case "month":
                    query += String.Format(" {0} DATEPART(YEAR, {1}_date) = {2}", conj, mode, year);
                    query += String.Format(" AND DATEPART(MONTH, {0}_date) = {1}", mode, month);
                    if (cID == -1) ReadIncomeOrExpense(mode, query);
                    else ReadIncomeOrExpense(mode, query, cID, cName);
                    break;
                case "day":
                    query += String.Format(" {0} DATEPART(YEAR, {1}_date) = {2}", conj, mode, year);
                    query += String.Format(" AND DATEPART(MONTH, {0}_date) = {1}", mode, month);
                    query += String.Format(" AND DATEPART(DAY, {0}_date) = {1}", mode, day);
                    if (cID == -1) ReadIncomeOrExpense(mode, query);
                    else ReadIncomeOrExpense(mode, query, cID, cName);
                    break;
                default:
                    MessageBox.Show("Invalid Interval!");
                    break;
            }
            outputPanel.Invalidate();
        }

        public void ViewBalance(string interval, int year, int month)
        {
            outputText.Clear();
            scrollPos = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string incomeQuery = "SELECT SUM(income_amount) FROM Income";
                string expenseQuery = "SELECT SUM(expense_amount) FROM Expense";
                int sumI, sumE, sumB;

                switch (interval)
                {
                    case "all":
                        sumI = GetSum(incomeQuery);
                        sumE = GetSum(expenseQuery);
                        sumB = sumI - sumE;
                        outputText.Add(String.Format("All Times | Total Income: {0} | Total Expense: {1} | Balance: {2}", sumI, sumE, sumB));
                        break;
                    case "yearly":
                        outputText.Add("Yearly Balance on All Times");
                        for (int i = startYear; i <= DateTime.Now.Year; i++)
                        {
                            sumI = GetSum(incomeQuery + String.Format(" WHERE DATEPART(YEAR, income_date) = {0}", i));
                            sumE = GetSum(expenseQuery + String.Format(" WHERE DATEPART(YEAR, expense_date) = {0}", i));
                            sumB = sumI - sumE;
                            outputText.Add(String.Format("Year {0} | Total Income: {1} | Total Expense: {2} | Balance: {3}", i, sumI, sumE, sumB));
                        }
                        break;
                    case "quarterly":
                        outputText.Add(String.Format("Quarterly Balance on Year {0}", year));
                        incomeQuery += String.Format("WHERE DATEPART(YEAR, income_date) = {0}", year);
                        expenseQuery += String.Format("WHERE DATEPART(YEAR, expense_date) = {0}", year);
                        int endQ = year == DateTime.Now.Year ? (DateTime.Now.Month - 1) / 3 + 1 : 4;
                        for (int i = 1; i < endQ; i++)
                        {
                            sumI = GetSum(incomeQuery + String.Format("AND DATEPART(QUARTER, income_date) = {0}", i));
                            sumE = GetSum(expenseQuery + String.Format("AND DATEPART(QUARTER, expense_date) = {0}", i));
                            sumB = sumI - sumE;
                            outputText.Add(String.Format("Year {0} | Quarter {1} | Total Income: {2} | Total Expense: {3} | Balance: {4}", year, i, sumI, sumE, sumB));
                        }
                        break;
                    case "monthly":
                        outputText.Add(String.Format("Monthly Balance on Year {0}", year));
                        incomeQuery += String.Format("WHERE DATEPART(YEAR, income_date) = {0}", year);
                        expenseQuery += String.Format("WHERE DATEPART(YEAR, expense_date) = {0}", year);
                        int endM = year == DateTime.Now.Year ? DateTime.Now.Month : 12;
                        for (int i = 1; i < endM; i++)
                        {
                            sumI = GetSum(incomeQuery + String.Format("AND DATEPART(MONTH, income_date) = {0}", i));
                            sumE = GetSum(expenseQuery + String.Format("AND DATEPART(MONTH, expense_date) = {0}", i));
                            sumB = sumI - sumE;
                            outputText.Add(String.Format("Year {0} | Month {1} | Total Income: {2} | Total Expense: {3} | Balance: {4}", year, i, sumI, sumE, sumB));
                        }
                        break;
                    case "weekly":
                        string headW = String.Format("Weekly Balance on Year {0}", year);
                        int endW = year == DateTime.Now.Year ? DateTime.Now.DayOfYear / 7 : 52;
                        if (month != 0)
                        {
                            headW += String.Format(" and Month {0}", month);
                            endW = year == DateTime.Now.Year && month == DateTime.Now.Month ? DateTime.Now.Day / 7 : 4;
                        }
                        outputText.Add(headW);
                        incomeQuery += String.Format("WHERE DATEPART(YEAR, income_date) = {0}", year);
                        expenseQuery += String.Format("WHERE DATEPART(YEAR, expense_date) = {0}", year);
                        for (int i = 1; i < endW; i++)
                        {
                            sumI = GetSum(incomeQuery + String.Format("AND DATEPART(WEEK, income_date) = {0}", i));
                            sumE = GetSum(expenseQuery + String.Format("AND DATEPART(WEEK, expense_date) = {0}", i));
                            sumB = sumI - sumE;
                            outputText.Add(String.Format("Year {0} | Week {1} | Total Income: {2} | Total Expense: {3} | Balance: {4}", year, i, sumI, sumE, sumB));
                        }
                        break;
                    case "daily":
                        string headD = String.Format("Daily Balance on Year {0}", year);
                        int endD = year == DateTime.Now.Year ? DateTime.Now.DayOfYear : DateTime.IsLeapYear(year) ? 366 : 365;
                        if (month != 0)
                        {
                            headD += String.Format(" and Month {0}", month);
                            endD = year == DateTime.Now.Year && month == DateTime.Now.Month ? DateTime.Now.Day : DateTime.DaysInMonth(year, month);
                        }
                        outputText.Add(headD);
                        incomeQuery += String.Format("WHERE DATEPART(YEAR, income_date) = {0}", year);
                        expenseQuery += String.Format("WHERE DATEPART(YEAR, expense_date) = {0}", year);
                        for (int i = 1; i < endD; i++)
                        {
                            sumI = GetSum(incomeQuery + String.Format("AND DATEPART(DAY, income_date) = {0}", i));
                            sumE = GetSum(expenseQuery + String.Format("AND DATEPART(DAY, expense_date) = {0}", i));
                            sumB = sumI - sumE;
                            outputText.Add(String.Format("Year {0} | Day {1} | Total Income: {2} | Total Expense: {3} | Balance: {4}", year, i, sumI, sumE, sumB));
                        }
                        break;
                    default:
                        MessageBox.Show("Invalid Interval!");
                        break;
                }
            }
            outputPanel.Invalidate();
        }

        private int GetSum(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object sumObj = command.ExecuteScalar();
                    if (sumObj != DBNull.Value)
                    {
                        int sum = Convert.ToInt32(sumObj);
                        return sum;
                    }
                    else return 0;
                }
            }
        }

        public void newEntryButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string mode = Convert.ToString(button.Tag);
            InputForm inputForm = new InputForm(this, mode);
            inputForm.ShowDialog();
        }

        public void searchButton_CLick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string mode = Convert.ToString(button.Tag);
            SearchForm searchForm = new SearchForm(this, mode);
            searchForm.ShowDialog();
        }

        public List<KeyValuePair<string, string>> GetTimePeriods(string mode)
        {
            if (mode == "balance") return timePeriods;
            else return timeIntervals;
        }

        public List<KeyValuePair<string, int>> GetCategories(string mode)
        {
            List<KeyValuePair<string, int>> categories = new List<KeyValuePair<string, int>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "";
                switch (mode)
                {
                    case "income":
                        query = "SELECT * FROM IncomeCategory";
                        break;
                    case "expense":
                        query = "SELECT * FROM ExpenseCategory";
                        break;
                    default: break;
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int cValue = reader.GetInt32(0);
                            string cKey = reader.GetString(1);
                            categories.Add(new KeyValuePair<string, int>(cKey, cValue));
                        }
                    }
                }
            }
            return categories;
        }

        public void UpdateStartYear()
        {
            startYear = GetStartYear();
        }

        public int GetStartYear()
        {
            (bool, bool) dbRows = DatabaseHasRows();
            if (dbRows.Item1 && dbRows.Item2)
            {
                int incomeYear;
                int expenseYear;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string incomeQuery = "SELECT MIN(income_date) FROM Income";
                    using (SqlCommand command = new SqlCommand(incomeQuery, connection))
                    {
                        DateTime oldestDate = Convert.ToDateTime(command.ExecuteScalar());
                        incomeYear = oldestDate.Year;
                    }

                    string expenseQuery = "SELECT MIN(expense_date) FROM expense";
                    using (SqlCommand command = new SqlCommand(expenseQuery, connection))
                    {
                        DateTime oldestDate = Convert.ToDateTime(command.ExecuteScalar());
                        expenseYear = oldestDate.Year;
                    }
                }
                return Math.Min(incomeYear, expenseYear);
            }
            else if (dbRows.Item1)
            {
                int incomeYear;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string incomeQuery = "SELECT MIN(income_date) FROM Income";
                    using (SqlCommand command = new SqlCommand(incomeQuery, connection))
                    {
                        DateTime oldestDate = Convert.ToDateTime(command.ExecuteScalar());
                        incomeYear = oldestDate.Year;
                    }
                }
                return incomeYear;
            }
            else if (dbRows.Item2)
            {
                int expenseYear;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string expenseQuery = "SELECT MIN(expense_date) FROM expense";
                    using (SqlCommand command = new SqlCommand(expenseQuery, connection))
                    {
                        DateTime oldestDate = Convert.ToDateTime(command.ExecuteScalar());
                        expenseYear = oldestDate.Year;
                    }
                }
                return expenseYear;
            }
            else return DateTime.Now.Year;
        }

        public (bool, bool) DatabaseHasRows()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int iI;
                int iE;
                connection.Open();
                string incomeQuery = "SELECT COUNT(*) FROM Income";
                using (SqlCommand command = new SqlCommand(incomeQuery, connection))
                {
                    iI = Convert.ToInt32(command.ExecuteScalar());
                }
                string expenseQuery = "SELECT COUNT(*) FROM Expense";
                using (SqlCommand command = new SqlCommand(expenseQuery, connection))
                {
                    iE = Convert.ToInt32(command.ExecuteScalar());

                }
                return (iI > 0, iE > 0);
            }
        }
    }
}