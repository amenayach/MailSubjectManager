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
            AddNewValue(tbSplitter.Text);
        }

        private void AddNewValue(string splitter)
        {
            var valuesCount = pnlValues.Controls.Count / 2;
            const int tbWidth = 126;
            const int lblWidth = 35;
            const int margin = 4;

            var tb = new TextBox
            {
                BackColor = Color.Black,
                ForeColor = Color.White,
                Location = new Point(valuesCount * (tbWidth + margin + lblWidth), 12),
                Name = "tbV" + valuesCount,
                Tag = valuesCount,
                Size = new Size(tbWidth, 20),
                TabIndex = valuesCount * 2,
                TextAlign = HorizontalAlignment.Center
            };

            var lbl = new Label
            {
                AutoSize = false,
                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(tb.Location.X + tbWidth + margin, 15),
                Name = "lblSp" + valuesCount,
                Tag = valuesCount,
                Size = new Size(35, 13),
                TabIndex = valuesCount * 2 + 1,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = splitter
            };

            pnlValues.Controls.Add(tb);
            pnlValues.Controls.Add(lbl);

            tb.Focus();
            lbl.BringToFront();
        }

        private void TemplateUC_Resize(object sender, EventArgs e)
        {
            pnlMain.RoundShape();
            this.RoundShape();
        }
    }
}
