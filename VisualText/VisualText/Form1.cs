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
    public partial class Form1 : Form
    {
        public int resX = 0;
        public int resY = 0;
        public int halfX = 0;
        public int locationY = 0;
        public int cESizeX = 0;
        public int cESizeY = 0;
        public int buttonIndex = 0;

        Label resLabel = new Label();
        Button newBlockBtn = new Button();

        public Form1()
        {
            InitializeComponent();
            onFormLoad();
            hideButton();
            codeEditor.Visible = false;
        }

        public void hideButton()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        public void showButton()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        public async void onFormLoad()
        {
            FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            WindowState = FormWindowState.Maximized;
            resX = Screen.PrimaryScreen.Bounds.Width;
            resY = Screen.PrimaryScreen.Bounds.Height;

            this.Controls.Add(resLabel);
            resLabel.Text = (resX + "x" + resY);
            resLabel.Font = new Font("Segoe UI Light", 24);
            resLabel.ForeColor = Color.FromArgb(1, 255, 255, 255);
            resLabel.Location = new Point(20, 20);
            resLabel.Size = new Size(100, 100);

            await Task.Delay(5000);

            calcCoords(resX, resY);
            initObjects(resX, resY);
        }

        public void calcCoords(int resX, int resY)
        {
            halfX = (resX / 2);
            locationY = (100);
            cESizeX = (resX - halfX - 50);
            cESizeY = (resY - 200);
        }

        public async void initObjects(int resX, int resY)
        {
            await Task.Delay(2000);
            resLabel.Location = new Point(halfX, locationY);
            resLabel.Text = "Position set. Initializing...";
            await Task.Delay(3500);
            resLabel.Visible = false;

            codeEditor.Visible = true;
            codeEditor.Location = new Point(halfX, locationY);
            codeEditor.Size = new Size(cESizeX, cESizeY);
            codeEditor.BackColor = Color.DarkGray;
            codeEditor.ForeColor = Color.White;
        }

        private void newItemBtn_Click(object sender, EventArgs e)
        {
            showButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawButton("button1");
            hideButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawButton("button2");
            hideButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawButton("button3");
            hideButton();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
        }

        public void drawButton(String buttonType)
        {
            Button newBlockAdded = new Button();
            this.Controls.Add(newBlockAdded);
            int pointX = (50);
            int pointY = (150 + (buttonIndex * 50));
            ++buttonIndex;
            newBlockAdded.Location = new Point(pointX, pointY);
            newBlockAdded.Size = new Size(150, 50);
            newBlockAdded.BackColor = Color.DarkGray;
            newBlockAdded.ForeColor = Color.White;
            newBlockAdded.Text = buttonType;
            newBlockAdded.Click += new System.EventHandler(this.dummy);
        }

        public void dummy(object sender, EventArgs e) {
            label1.Text = "mars";
        } 

        private void enterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (label1.Text.Equals("enter pressed"))
                {
                    label1.Text = "eeeeeeeeeeeeeeee";
                }
                else
                {
                    label1.Text = "enter pressed";
                }
            }
        }
    }
}
