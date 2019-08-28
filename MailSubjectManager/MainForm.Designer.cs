namespace MailSubjectManager
{
    partial class MainForm
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
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateUC1 = new MailSubjectManager.UserControls.TemplateUC();
            this.ctxNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbarIcon
            // 
            this.taskbarIcon.ContextMenuStrip = this.ctxNotify;
            this.taskbarIcon.Icon = global::MailSubjectManager.Properties.Resources.mailicon;
            this.taskbarIcon.Text = "Mail Subject Manager";
            this.taskbarIcon.Visible = true;
            this.taskbarIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskbarIcon_MouseClick);
            // 
            // ctxNotify
            // 
            this.ctxNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.ctxNotify.Name = "ctxNotify";
            this.ctxNotify.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // templateUC1
            // 
            this.templateUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateUC1.BackColor = System.Drawing.Color.White;
            this.templateUC1.Location = new System.Drawing.Point(12, 12);
            this.templateUC1.Name = "templateUC1";
            this.templateUC1.Size = new System.Drawing.Size(776, 61);
            this.templateUC1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.templateUC1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::MailSubjectManager.Properties.Resources.mailicon;
            this.Name = "MainForm";
            this.Text = "Mail Subject Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctxNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon taskbarIcon;
        private System.Windows.Forms.ContextMenuStrip ctxNotify;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private UserControls.TemplateUC templateUC1;
    }
}

