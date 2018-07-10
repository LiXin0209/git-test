using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class index_layout
    {
        public void a(Form fr)
        {
            fr.Top = 40;
            fr.Left = 16;
        }
        public void b(Form fr)
        {
            foreach (Form f in fr.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
        }
    }
   
}
