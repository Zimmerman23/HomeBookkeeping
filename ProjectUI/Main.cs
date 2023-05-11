using ProjectBL.Controller;
using ProjectBL.Model;
using ProjectUI.Forms;
using System;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class Main : Form
    {
        ProjectContext db;
        public Main()
        {
            InitializeComponent();
            db = new ProjectContext();
        }

        private void AddIncomeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new IncomeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Incomes.Add(form.Income);
                db.SaveChanges();
            }
        }

        private void AddExpenseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ExpenseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Expenses.Add(form.Expense);
                db.SaveChanges();
            }
        }

        private void ShowIncomeStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var incomeCatalog = new Catalog<Income>(db.Incomes);
            incomeCatalog.Show();
        }

        private void ShowExpenseStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var expenseCatalog = new Catalog<Expense>(db.Expenses);
            expenseCatalog.Show();
        }
    }
}
