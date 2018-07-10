using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class index_employees : Form
    {
        public index_employees()
        {
            InitializeComponent();
        }

        private void admin_employees_Load(object sender, EventArgs e)
        {
            index_layout index = new index_layout();
            index.a(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
