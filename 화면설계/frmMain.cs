using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 화면설계
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmMemberInfo memberForm = new frmMemberInfo();
            memberForm.MdiParent = this;
            memberForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSales FrmSales = new frmSales();
            FrmSales.MdiParent = this;
            FrmSales.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent=this;         
            login.Show();
            login.Focus();
            
        }

        private void 통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraph graph = new frmGraph();
            graph.Show();
        }
    }
}
