using ProjectBL.Controller;
using ProjectBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectUI.Forms
{
    public partial class IncomeForm : Form
    {
        public Income Income { get; set; }
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ProjectContext db = new ProjectContext();
            var income = new Income(db.Incomes.Count(), DateTime.Parse(dateTimePicker1.Text), (double)numericUpDown1.Value, 
                (double)numericUpDown2.Value, (double)numericUpDown3.Value);
            Income = income;
            Close();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
