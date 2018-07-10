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
    public partial class index_Warehouse_location : Form
    {
        public index_Warehouse_location()
        {
            InitializeComponent();
        }

        private void index_Warehouse_location_Load(object sender, EventArgs e)
        {
            index_layout index = new index_layout();
            index.a(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
