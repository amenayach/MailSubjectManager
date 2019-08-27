using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSubjectManager.UserControls
{
    public partial class TemplateUC : UserControl
    {
        public TemplateUC()
        {
            InitializeComponent();
            pnlMain.RoundShape();
            this.RoundShape();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
