using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualText
{
    public partial class Form2 : Form
    {
        public static int resX = 0;
        public static int resY = 0;
        public static string filePath = "";
        public int resizeCount = 0;
        newTSMIC newTSMIC = new newTSMIC();
        openTSMIC openTSMIC = new openTSMIC();
        saveTSMIC saveTSMIC = new saveTSMIC();
        basicDDBC basicDDBC = new basicDDBC();
        logicDDBC logicDDBC = new logicDDBC();
        public static bool darkModeEnabled = true;
        int resizedXI, resizedXIII, resizedYI, resizedYIII, resized20, resized80;
        public static LinkedList<Button> blocks = new LinkedList<Button>();
        public static Dictionary<string, string> storedVariables = new Dictionary<string, string>();

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

        #region resizable window
        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;

        private void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            Mx = MousePosition.X;
            My = MousePosition.Y;
            Sw = Width;
            Sh = Height;
        }

        private void SizerMouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true) {
                Width = (MousePosition.X - Mx + Sw);
                Height = (MousePosition.Y - My + Sh);
            }
        }

        private void SizerMouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }
        #endregion

        public Form2() ////////////////////////////////////////// MAIN
        {
            InitializeComponent();
            onLoad();
            activateDarkMode();
            removeBorders();
            this.Resize += new System.EventHandler(this.onResize);
            Form2.resLabel.Visible = false;
        }

        public void onResize(object sender, EventArgs e) {
            resX = this.Width;
            resY = this.Height;

            double resizedX = (Form2.resX * 0.25);
            resizedXI = (int)resizedX;
            double resizedXII = (Form2.resX * 0.75);
            resizedXIII = (int)resizedXII;

            double resized25a = (Form2.resX * 0.25);
            int resized25 = (int)resized25a;
            double resized75a = (Form2.resX * 0.75);
            int resized75 = (int)resized75a;

            double resizedY = (Form2.resX * 0.8);
            resizedYI = (int)resizedY;
            double resizedYII = (Form2.resY * 0.33);
            resizedYIII = (int)resizedYII;

            double resized20a = (Form2.resX * 0.17);
            resized20 = (int)resized20a;
            double resized80a = (Form2.resY * 0.83);
            resized80 = (int)resized80a;

            /*
            Form2.resLabel.Text = (Form2.resX + "x" + Form2.resY);
            Form2.resLabel.Font = new Font("Segoe UI Light", 16);
            Form2.resLabel.Size = new Size(1000, 100);
            Form2.resLabel.Location = new Point(resizedYI, resizedYIII);
            */

            Form2.codeEditor.Location = new Point(4, 70);
            Form2.codeEditor.Font = new Font("Courier New", 16);
            Form2.codeEditor.Size = new Size((Form2.resX - resizedXI), (Form2.resY - resized20 - 5));

            Form2.codeOutput.Location = new Point(4, (Form2.resY - resized20 + 70));
            Form2.codeOutput.Font = new Font("Consolas", 16);
            Form2.codeOutput.Size = new Size((Form2.resX), resized20 - 75);
           
            //this.FormBorderStyle = FormBorderStyle.Sizable;

            this.pictureBox1.Location = new Point(resX - 16, resY - 16);
            this.pictureBox1.Size = new Size(16, 16);

            for (int i = 0; i < Form2.blocks.Count(); ++i)
            {
                Form2.blocks.ElementAt(i).Location = new Point((resized75 + 12), Form2.blocks.ElementAt(i).Location.Y);
                Form2.blocks.ElementAt(i).Size = new Size((resized25 - 50), Form2.blocks.ElementAt(i).Size.Height);
                while (Form2.blocks.ElementAt(i).Width < System.Windows.Forms.TextRenderer.MeasureText(Form2.blocks.ElementAt(i).Text, new Font(Form2.blocks.ElementAt(i).Font.FontFamily, Form2.blocks.ElementAt(i).Font.Size, Form2.blocks.ElementAt(i).Font.Style)).Width)
                {
                    Form2.blocks.ElementAt(i).Font = new Font(Form2.blocks.ElementAt(i).Font.FontFamily, Form2.blocks.ElementAt(i).Font.Size - 0.5f, Form2.blocks.ElementAt(i).Font.Style);
                }
            }
        }

        public void onLoad() {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Controls.Add(Form2.resLabel);
            this.Controls.Add(Form2.codeEditor);
            this.Controls.Add(Form2.codeOutput);
        }

        #region menu one
        public class tsRenderer : ToolStripSystemRenderer
        {
            public tsRenderer() { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                base.OnRenderToolStripBorder(e);
            }
        }

        public void lightdarkSwitch(object sender, EventArgs e)
        {
            if (darkModeEnabled == true)
            {
                activateLightMode();
                darkModeEnabled = false;
                lightdarkTTSB.Text = "Dark mode";
            }
            else
            {
                activateDarkMode();
                darkModeEnabled = true;
                lightdarkTTSB.Text = "Light mode";
            }
        }

        public void activateDarkMode()
        {
            toolStrip1.ForeColor = ColorTranslator.FromHtml("#e2e2e2");
            toolStrip1.BackColor = ColorTranslator.FromHtml("#303030");
            toolStrip2.ForeColor = ColorTranslator.FromHtml("#e2e2e2");
            toolStrip2.BackColor = ColorTranslator.FromHtml("#282828");
            this.ForeColor = ColorTranslator.FromHtml("#e2e2e2");// save it somewhere. 
            this.BackColor = ColorTranslator.FromHtml("#202020");// we can do it like scratch, logic can bve a colour, ui can be another etc //yea that would work
            Form2.codeEditor.ForeColor = ColorTranslator.FromHtml("#e3e3e3");
            Form2.codeEditor.BackColor = ColorTranslator.FromHtml("#252525");
            Form2.codeOutput.ForeColor = ColorTranslator.FromHtml("#e3e3e3");
            Form2.codeOutput.BackColor = ColorTranslator.FromHtml("#252525");
            Form2.resLabel.ForeColor = ColorTranslator.FromHtml("#e3e3e3");
            Form2.resLabel.BackColor = ColorTranslator.FromHtml("#252525");
            minTTSB.Image = global::VisualText.Properties.Resources.transparentminus;
            maxTTSB.Image = global::VisualText.Properties.Resources.transparentsquare;
            closeTTSB.Image = global::VisualText.Properties.Resources.transparentx;
            useriDDB.Image = global::VisualText.Properties.Resources.transparentui;
            for (int i = 0; i < Form2.blocks.Count(); ++i)
            {
                if (Form2.blocks.ElementAt(i).BackColor.Equals(ColorTranslator.FromHtml("#11d613")))
                {
                    Form2.blocks.ElementAt(i).BackColor = ColorTranslator.FromHtml("#1f7a20");
                }
                if (Form2.blocks.ElementAt(i).BackColor.Equals(ColorTranslator.FromHtml("#3b5bff")))
                {
                    Form2.blocks.ElementAt(i).BackColor = ColorTranslator.FromHtml("#001fbd");
                }
                if (Form2.blocks.ElementAt(i).BackColor.Equals(ColorTranslator.FromHtml("#d226fc")))
                {
                    Form2.blocks.ElementAt(i).BackColor = ColorTranslator.FromHtml("#a108c7");
                }
            }
        } //it's the law!

        public void activateLightMode()
        {
            toolStrip1.ForeColor = ColorTranslator.FromHtml("#1F1F1F");
            toolStrip1.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            toolStrip2.ForeColor = ColorTranslator.FromHtml("#1F1F1F");
            toolStrip2.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            this.ForeColor = ColorTranslator.FromHtml("#1C1C1C");
            this.BackColor = ColorTranslator.FromHtml("#FBFBFB");
            Form2.codeEditor.ForeColor = ColorTranslator.FromHtml("#222222");
            Form2.codeEditor.BackColor = ColorTranslator.FromHtml("#EEEEEE");
            Form2.codeOutput.ForeColor = ColorTranslator.FromHtml("#222222");
            Form2.codeOutput.BackColor = ColorTranslator.FromHtml("#EEEEEE");
            Form2.resLabel.ForeColor = ColorTranslator.FromHtml("#222222");
            Form2.resLabel.BackColor = ColorTranslator.FromHtml("#EEEEEE");
            minTTSB.Image = global::VisualText.Properties.Resources.Minimize_transparent;
            maxTTSB.Image = global::VisualText.Properties.Resources.Windowed_transparent;
            closeTTSB.Image = global::VisualText.Properties.Resources.X_transparent2;
            useriDDB.Image = global::VisualText.Properties.Resources.UI_Transparent;
            for (int i = 0; i < Form2.blocks.Count(); ++i)
            {
                if (Form2.blocks.ElementAt(i).BackColor.Equals(ColorTranslator.FromHtml("#1f7a20")))
                {
                    Form2.blocks.ElementAt(i).BackColor = ColorTranslator.FromHtml("#11d613");
                }
                if (Form2.blocks.ElementAt(i).BackColor.Equals(ColorTranslator.FromHtml("#001fbd")))
                {
                    Form2.blocks.ElementAt(i).BackColor = ColorTranslator.FromHtml("#3b5bff");
                }
                if (Form2.blocks.ElementAt(i).BackColor.Equals(ColorTranslator.FromHtml("#a108c7")))
                {
                    Form2.blocks.ElementAt(i).BackColor = ColorTranslator.FromHtml("#d226fc");
                }
            }
        } //light mode isn't that bad tbh

        public async void removeBorders()
        {
            toolStrip1.Renderer = new tsRenderer();
            toolStrip2.Renderer = new tsRenderer();
        }

        /*public void drawNewBorder(object sender, PaintEventArgs e) {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(1, 10, 10, 10), 4), this.DisplayRectangle);
        }*/

        public void minW(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void maxW(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
            }
            else {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        public void closeW(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region menu two
        public void newTSMIF(object sender, EventArgs e)
        {
            newTSMIC.newTSMIF();
        }

        public void openTSMIF(object sender, EventArgs e)
        {
            openTSMIC.openTSMIF();
        }

        public void saveTSMIF(object sender, EventArgs e)
        {
            saveTSMIC.saveTSMIF();
        }

        public void closeTSMIF(object sender, EventArgs e)
        {
            closeTSMIC.closeTSMIF();
        }

        /// <summary>
        /// Basic
        /// </summary>

        public void basicDDBF(object sender, EventArgs e)
        {
            //Empty
        }

        public void printTSMIF(object sender, EventArgs e)
        {
            basicDDBC.printTSMIF();
        }
        public void printlnTSMIF(object sender, EventArgs e)
        {
            basicDDBC.printlnTSMIF();
        }

        public void inputTSMIF(object sender, EventArgs e)
        {
            basicDDBC.inputTSMIF();
        }

        public void addSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathAdd();
        }

        public void subSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathSub();
        }

        public void multiSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathMulti();
        }

        public void divSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathDiv();
        }

        public void modSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathPwr();
        }

        public void sqrtSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathPwr();
        }

        public void pwrSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.mathTSMISC.mathPwr();
        }

        public void rIntSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.randomTSMISC.randomInt();
        }

        public void rDoubleSTSMIF(object sender, EventArgs e)
        {
            basicDDBC.randomTSMISC.randomDec();
        }

        /// <summary>
        /// Data
        /// </summary>

        public void dataDDBF(object sender, EventArgs e)
        {

        }

        public void stringVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newString();
        }

        public void intVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newInt();
        }

        public void longVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newLong();
        }

        public void doubleVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newDouble();
        }

        public void booleanVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newBoolean();
        }

        public void arrayVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newArray();
        }

        public void linkedListVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newLinkedList.create();
        }

        public void dictionaryVTSMIF(object sender, EventArgs e)
        {
            dataDDBC.newDictionary.create();
        }

        public void logicDDBF(object sender, EventArgs e)
        {

        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicDDBC.forTSMIF();
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicDDBC.whileTSMIF();
        }

        public void fileioDDBF(object sender, EventArgs e)
        {

        }

        public void oopDDBF(object sender, EventArgs e)
        {

        }

        public void useriDDBF(object sender, EventArgs e)
        {

        }
        #endregion

        #region draw blocks
        public void runProgram(object sender, EventArgs e)
        {
            for (int i = 0; i < blocks.Count(); ++i)
            {
                blocks.ElementAt(i).Visible = false;
            }
            blocks.Clear();
            Form2.codeOutput.Text = "";
            scanCode.blockIndex = 0;
            scanCode.start();
            drawBlocks();
        }
        public void drawBlocks() {
            int numOfElements = blocks.Count();
            for (int i = 0; i < numOfElements; ++i) {
                this.Controls.Add(blocks.ElementAt(i));
            }
        }
        #endregion
    }
}
