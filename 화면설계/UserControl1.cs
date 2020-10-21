using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace 화면설계
{
    public partial class UserControl1 : UserControl
    {
        string lbltext = string.Empty;
        public UserControl1()
        {
            InitializeComponent();
        }
        public void SetDateValue(string asd)
        {
            lbltext = asd;
            label1.Text = lbltext;
        }
    }
}
