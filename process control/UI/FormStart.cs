using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace leihao.PCPC.UI
{
    public partial class FormStart : Form
    {

        public FormStart()
        {
            InitializeComponent();
        }
        //窗体显示时
        private void FormStart_Shown(object sender, EventArgs e)
        {
            //加载FormMain窗体
            Application.DoEvents();
            Program.frmMain = new FormMain();
            Program.frmMain.Show();
            this.Hide();
        }
    }
}
