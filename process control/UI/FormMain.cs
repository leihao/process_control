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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //将程序显示到前台
        public void ShowFormToFront()
        {
                if (this.WindowState == FormWindowState.Minimized) //如果是最小化则恢复
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.TopMost = true;
                this.Activate();
                this.TopMost = false;
        }

        private void FormMain_FormClosing(object sender, EventArgs e)
        {
            //释放图标
            notifyIcon.Dispose();
            //退出程序
            Program.frmStart.Close();
        }

        //程序隐藏后提示
        private bool alreayTipMinimize = false;
        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            if (!alreayTipMinimize)
            {
                if (!this.Visible)
                {
                    notifyIcon.ShowBalloonTip(1500, "已经最小化到系统托盘", "您可以双击此图标以重新显示", ToolTipIcon.Info);
                    alreayTipMinimize = true;
                }
            }
        }

        //显示/隐藏窗口
        private void mnuTrayShowHide_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (this.WindowState == FormWindowState.Minimized) //如果最小化则恢复Normal
                    this.WindowState = FormWindowState.Normal;
                else
                    this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
            this.TopMost = true;
            this.Activate();
            this.TopMost = false;
        }

        //双击托盘图标
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mnuTrayShowHide_Click(sender, EventArgs.Empty);
        }

        //定时器刷新
        private void timer_Tick(object sender, EventArgs e)
        {

        }

        //托盘右键单击
        private void trayMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.Visible)
            {
                if (this.WindowState == FormWindowState.Minimized) //如果最小化则恢复Normal
                    ToolStripMenuItem_ShowHide.Text = "恢复";
                else
                    ToolStripMenuItem_ShowHide.Text = "隐藏";
            }
            else
            {
                ToolStripMenuItem_ShowHide.Text = "显示";
            }
        }
    }
}
