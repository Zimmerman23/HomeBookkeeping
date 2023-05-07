using ProjectBL.Controller;
using ProjectBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectUI.Forms
{
    public partial class ExpenseForm : Form
    {
        public Expense Expense { get; set; }
        public ExpenseForm()
        {
            InitializeComponent();

        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            ProjectContext db = new ProjectContext();
            var expense = new Expense(db.Expenses.Count(), DateTime.Parse(dateTimePicker1.Text), (double)numericUpDown1.Value,
                (double)numericUpDown2.Value, (double)numericUpDown3.Value, (double)numericUpDown4.Value,
                (double)numericUpDown5.Value, (double)numericUpDown6.Value);
            Expense = expense;
            Close();
        }
    }
}
