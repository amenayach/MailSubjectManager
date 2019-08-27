using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSubjectManager
{
    public partial class MainForm : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;
        private bool allowClose = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;
        }

        private void M_GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            Text = $"Ctrl: {e.Control} Shift: {e.Shift} Alt: {e.Alt} Key: {e.KeyCode}";
        }

        public void Unsubscribe()
        {
            m_GlobalHook.KeyDown -= M_GlobalHook_KeyDown;

            m_GlobalHook.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowClose)
            {
                Unsubscribe();
            }
            else
            {
                this.Hide();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            this.Close();
        }

        private void TaskbarIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = !this.Visible;
            }
        }
    }
}
