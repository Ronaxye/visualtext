using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualText
{
    class openTSMIC
    {
        public void openTSMIF()
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.ShowDialog();
            Form2.filePath = oFD.FileName;
            Form2.codeEditor.Text = "";
            try
            {
                int numOfLines = File.ReadLines(Form2.filePath).Count();
                for (int i = 0; i < numOfLines; ++i)
                {
                    string line = File.ReadLines(Form2.filePath).Skip(i).Take(1).First();
                    Form2.codeEditor.Text += (line + "\n");
                }
                Form2.openfileTTSL.Text = ("Currently open file: " + Form2.filePath);
            }
            catch (Exception Ex) {
                Form2.resLabel.Text = "An error occured.";
                System.Media.SystemSounds.Hand.Play();
            }
        }
    }
}
