namespace leihao.PCPC.UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.KillProgram = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_ShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_silence = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ProlistView = new System.Windows.Forms.ListView();
            this.columnHeader_PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ProgramName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_IO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.trayMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // KillProgram
            // 
            this.KillProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KillProgram.Location = new System.Drawing.Point(436, 1);
            this.KillProgram.Name = "KillProgram";
            this.KillProgram.Size = new System.Drawing.Size(75, 23);
            this.KillProgram.TabIndex = 1;
            this.KillProgram.Text = "结束进程";
            this.KillProgram.UseVisualStyleBackColor = true;
            this.KillProgram.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PCPC";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ShowHide,
            this.ToolStripMenuItem_silence,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_exit});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(164, 98);
            this.trayMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.trayMenuStrip_Opening);
            // 
            // ToolStripMenuItem_ShowHide
            // 
            this.ToolStripMenuItem_ShowHide.Name = "ToolStripMenuItem_ShowHide";
            this.ToolStripMenuItem_ShowHide.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_ShowHide.Text = "显示/隐藏主窗口";
            this.ToolStripMenuItem_ShowHide.Click += new System.EventHandler(this.mnuTrayShowHide_Click);
            // 
            // ToolStripMenuItem_silence
            // 
            this.ToolStripMenuItem_silence.Enabled = false;
            this.ToolStripMenuItem_silence.Name = "ToolStripMenuItem_silence";
            this.ToolStripMenuItem_silence.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_silence.Text = "免扰模式";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_exit.Text = "退出";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.FormMain_FormClosing);
            // 
            // ProlistView
            // 
            this.ProlistView.AllowColumnReorder = true;
            this.ProlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_PID,
            this.columnHeader_ProgramName,
            this.columnHeader_CPU,
            this.columnHeader_memory,
            this.columnHeader_IO});
            this.ProlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProlistView.FullRowSelect = true;
            this.ProlistView.GridLines = true;
            this.ProlistView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProlistView.Location = new System.Drawing.Point(0, 24);
            this.ProlistView.Name = "ProlistView";
            this.ProlistView.Size = new System.Drawing.Size(511, 330);
            this.ProlistView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ProlistView.TabIndex = 2;
            this.ProlistView.UseCompatibleStateImageBehavior = false;
            this.ProlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_PID
            // 
            this.columnHeader_PID.Text = "PID";
            this.columnHeader_PID.Width = 38;
            // 
            // columnHeader_ProgramName
            // 
            this.columnHeader_ProgramName.Text = "程序/进程";
            this.columnHeader_ProgramName.Width = 143;
            // 
            // columnHeader_CPU
            // 
            this.columnHeader_CPU.Text = "CPU占用率(%)";
            this.columnHeader_CPU.Width = 88;
            // 
            // columnHeader_memory
            // 
            this.columnHeader_memory.Text = "内存占用(Byte)";
            this.columnHeader_memory.Width = 99;
            // 
            // columnHeader_IO
            // 
            this.columnHeader_IO.Text = "I/O占用(次)";
            this.columnHeader_IO.Width = 87;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.隐藏ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(511, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.隐藏ToolStripMenuItem.Text = "隐藏(&H)";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.mnuTrayShowHide_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.FormMain_FormClosing);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.KillProgram);
            this.Controls.Add(this.ProlistView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "PCPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            this.trayMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KillProgram;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ListView ProlistView;
        private System.Windows.Forms.ColumnHeader columnHeader_ProgramName;
        private System.Windows.Forms.ColumnHeader columnHeader_CPU;
        private System.Windows.Forms.ColumnHeader columnHeader_memory;
        private System.Windows.Forms.ColumnHeader columnHeader_IO;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ShowHide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_silence;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader columnHeader_PID;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}