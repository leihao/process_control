namespace leihao.PCPC.UI
{
    partial class FormStart
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
            this.WelcomeText = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TipText = new System.Windows.Forms.Label();
            this.Waitetimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WelcomeText.Location = new System.Drawing.Point(12, 9);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(136, 56);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "PCPC";
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Location = new System.Drawing.Point(67, 75);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(101, 12);
            this.TipText.TabIndex = 1;
            this.TipText.Text = "个人电脑进程管理";
            // 
            // Waitetimer
            // 
            this.Waitetimer.Enabled = true;
            this.Waitetimer.Interval = 1234;
            this.Waitetimer.Tick += new System.EventHandler(this.FormStart_Shown);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 98);
            this.Controls.Add(this.TipText);
            this.Controls.Add(this.WelcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCPC启动中...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeText;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.Timer Waitetimer;
    }
}