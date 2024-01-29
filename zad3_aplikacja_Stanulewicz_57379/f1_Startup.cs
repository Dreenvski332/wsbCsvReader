using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3_aplikacja_Stanulewicz_57379
{
    public partial class f1_Startup : Form
    {
        public f1_Startup()
        {
            InitializeComponent();
        }
        private void f1_startUpButton_Click(object sender, EventArgs e)
        {
            f2_Body openf2Body = new f2_Body();
            openf2Body.ShowDialog();
        }
    }
}
