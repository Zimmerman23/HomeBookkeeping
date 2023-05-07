using System.Data.Entity;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }
    }
}
