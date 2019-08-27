namespace MailSubjectManager
{
    using System.Drawing;
    using System.Windows.Forms;
    using System.Drawing.Drawing2D;

    public static class Helper
    {
        public static void RoundShape(this Control ctl, float CirRay = 14f)
        {
            var gr = new GraphicsPath();
            gr.AddPie(0, 0, CirRay, CirRay, 180f, 90f);
            gr.AddPie(ctl.Width - CirRay, 0, CirRay, CirRay, 270f, 90f);
            gr.AddPie(0, ctl.Height - CirRay, CirRay, CirRay, 90f, 90f);
            gr.AddPie(ctl.Width - CirRay, ctl.Height - CirRay, CirRay, CirRay, 0f, 90f);

            gr.AddRectangle(new Rectangle((int)CirRay / 2, 0, (int)(ctl.Width - CirRay), (int)ctl.Height));
            gr.AddRectangle(new Rectangle(0, (int)CirRay / 2, (int)CirRay / 2, (int)(ctl.Height - CirRay)));
            gr.AddRectangle(new Rectangle((int)(ctl.Width - CirRay / 2), (int)CirRay / 2, (int)CirRay / 2, (int)(ctl.Height - CirRay)));

            ctl.Region = new Region(gr);
        }
    }
}
