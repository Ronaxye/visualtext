using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualText
{
    public partial class splashScreen : Form
    {
        private static int ResX, ResY;
        public splashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            GetScreenRes();
            this.ShowInTaskbar = false;
            InitSplash();
        }

        private void GetScreenRes()
        {
            this.WindowState = FormWindowState.Maximized;
            ResX = this.Width;
            ResY = this.Height;
            this.WindowState = FormWindowState.Normal;
        }

        private async void InitSplash()
        {
            this.Size = new Size(575, 340);
            this.Opacity = 1.0f;
            this.CenterToScreen();
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(575, 340);

            await Task.Delay(2500);
            for (int i = 0; i < 20; ++i)
            {
                this.Opacity -= 0.05f;
                await Task.Delay(50);
            }

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
