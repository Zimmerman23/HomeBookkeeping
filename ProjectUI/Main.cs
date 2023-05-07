using ProjectBL.Controller;
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

        private void IncomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new IncomeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Incomes.Add(form.Income);
                db.SaveChanges();
            }
        }

        private void ExpenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ExpenseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Expenses.Add(form.Expense);
                db.SaveChanges();
            }
        }
    }
}
