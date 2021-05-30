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
    public partial class tutorial : Form
    {
        public tutorial()
        {
            InitializeComponent();
            initRichTextBox();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        #region moveable window
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void onMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        #endregion

        private void initRichTextBox()
        {
            richTextBox1.LoadFile("Resources\\WelcomeTutorial.rtf");
            richTextBox1.ReadOnly = true;

            richTextBox2.LoadFile("Resources\\T1.rtf");
            richTextBox2.ReadOnly = true;

            richTextBox3.LoadFile("Resources\\T2.rtf");
            richTextBox3.ReadOnly = true;

            richTextBox4.LoadFile("Resources\\T3.rtf");
            richTextBox4.ReadOnly = true;

            richTextBox5.LoadFile("Resources\\T4.rtf");
            richTextBox5.ReadOnly = true;

            richTextBox6.LoadFile("Resources\\T5.rtf");
            richTextBox6.ReadOnly = true;

            richTextBox7.LoadFile("Resources\\T6.rtf");
            richTextBox7.ReadOnly = true;

            richTextBox8.LoadFile("Resources\\T7.rtf");
            richTextBox8.ReadOnly = true;

            richTextBox9.LoadFile("Resources\\T8.rtf");
            richTextBox9.ReadOnly = true;

            richTextBox10.LoadFile("Resources\\T9.rtf");
            richTextBox10.ReadOnly = true;

            richTextBox11.LoadFile("Resources\\T10.rtf");
            richTextBox11.ReadOnly = true;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
