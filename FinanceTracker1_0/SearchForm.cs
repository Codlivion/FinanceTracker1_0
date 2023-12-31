using System;
using System.Windows.Forms;

namespace FinanceTracker1_0
{
    public partial class SearchForm : Form
    {
        MainForm mainForm;
        string formMode;
        Label[] labels;
        NumericUpDown[] numBoxes;

        public SearchForm(MainForm main, string mode)
        {
            InitializeComponent();
            mainForm = main;
            formMode = mode;
            yearBox.Minimum = mainForm.GetStartYear();
            yearBox.Maximum = DateTime.Now.Year;
            yearBox.Value = yearBox.Maximum;
            labels = new Label[3] { yearLabel, monthLabel, dayLabel };
            numBoxes = new NumericUpDown[3] { yearBox,  monthBox, dayBox };

            SetMode();
            yearBox.ValueChanged += SetValueLimits;
            monthBox.ValueChanged += SetValueLimits;
        }

        public void SetMode()
        {
            switch (formMode)
            {
                case "income":
                    topLabel.Text += " Income";
                    break;
                case "expense":
                    topLabel.Text += " Expense";
                    break;
                case "balance":
                    topLabel.Text += " Balance";
                    break;
                default:
                    Close();
                    break;
            }
            FillLists();
        }

        private void FillLists()
        {
            if (formMode == "income" || formMode == "expense")
            {
                categoryBox.DataSource = mainForm.GetCategories(formMode);
                categoryBox.DisplayMember = "Key";
                categoryBox.ValueMember = "Value";
            }
            else
            {
                categoryLabel.Visible = false;
                categoryBox.Visible = false;
            }
            intervalBox.DataSource = mainForm.GetTimePeriods(formMode);
            intervalBox.DisplayMember = "Key";
            intervalBox.ValueMember = "Value";
        }

        private void SetValueLimits(object sender, EventArgs e)
        {
            int i = intervalBox.SelectedIndex;
            HideIntervals();
            if (formMode == "balance")
            {
                switch (i)
                {
                    case 2: case 3:
                        ShowIntervals(1);
                        break;
                    case 4: case 5:
                        ShowIntervals(2);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 1:
                        ShowIntervals(1);
                        break;
                    case 2:
                        ShowIntervals(2);
                        break;
                    case 3:
                        ShowIntervals(3);
                        SetDayMax();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ShowHideYear(object sender, EventArgs e)
        {
            if (formMode == "balance" && !monthBox.Visible)
            { yearBox.Visible = !yearBox.Visible; }
        }

        private void ShowHideMonth(object sender, EventArgs e)
        {
            if (formMode == "balance")
            { monthBox.Visible = !monthBox.Visible; }
        }

        private void ShowIntervals(int n)
        {
            if (n > 3) return;
            for (int i = 0; i < n; i++)
            {
                labels[i].Visible = true;
                numBoxes[i].Visible = true;
            }
        }

        private void SetDayMax()
        {
            dayBox.Maximum = DateTime.DaysInMonth((int)yearBox.Value, (int)monthBox.Value);
        }

        private void HideIntervals()
        {
            for (int i = 0; i < 3; i++)
            {
                labels[i].Visible = false;
                numBoxes[i].Visible = false;
            }
        }

        private void filterCategory_Click(object sender, EventArgs e)
        {
            categoryBox.Visible = !categoryBox.Visible;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int categoryID = categoryBox.Visible ? Convert.ToInt32(categoryBox.SelectedValue) : -1;
            string categoryName = categoryBox.Text;
            string interval = Convert.ToString(intervalBox.SelectedValue);
            int year = yearBox.Visible ? Convert.ToInt32(yearBox.Value) : DateTime.Now.Year;
            int month = monthBox.Visible ? Convert.ToInt32(monthBox.Value) : 0;
            int day = dayBox.Visible ? Convert.ToInt32(dayBox.Value) : 0;

            if (formMode == "income" || formMode == "expense")
            {
                if (categoryID != -1) mainForm.ViewIncomeOrExpense(formMode, interval, year, month, day, categoryID, categoryName);
                else mainForm.ViewIncomeOrExpense(formMode, interval, year, month, day);
                Close();
            }
            else if (formMode == "balance")
            {
                mainForm.ViewBalance(interval, year, month);
                Close();
            }
        }
    }
}