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
    public partial class admin_index : Form
    {
        public admin_index()
        {
            InitializeComponent();
        }
        index_layout index = new index_layout();
        private void 添加器具ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void admin_index_Load(object sender, EventArgs e)
        {

        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index.b(this);
            Form fr = new index_employees();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 系统字典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index.b(this);
            Form fr = new index_dictionary();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 仓库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 仓库状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 器件出入记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 仓库编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index.b(this);
            Form fr = new index_Warehouse_management();
            fr.MdiParent = this;
            fr.Show();
        }

        private void 位置编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index.b(this);
            Form fr = new index_Warehouse_location();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
