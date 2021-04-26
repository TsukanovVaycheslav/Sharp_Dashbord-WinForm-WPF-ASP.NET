using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dashbord03_Messenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_MouseEnter(object sender, EventArgs e)
        {
          // ((Guna.UI2.WinForms.Guna2AnimateWindow)sender).ShadowDecoration.Color = Color.DeepPink;
        }

        private void guna2GradientPanel1_MouseLeave(object sender, EventArgs e)
        {
          // ((Guna.UI2.WinForms.Guna2AnimateWindow)sender).ShadowDecoration.Color = Color.FromArgb(17,22,32);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
