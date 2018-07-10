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
    public partial class index_Warehouse_management : Form
    {
        public index_Warehouse_management()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void index_Warehouse_management_Load(object sender, EventArgs e)
        {
            index_layout index = new index_layout();
            index.a(this);
        }
    }
}
