using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualText
{
    class newTSMIC
    {
        public void newTSMIF()
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Title = "Save code to: ";
            sFD.Filter = "VisualText Code File (*.vtxt)|*.vtxt";
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                Form2.filePath = sFD.FileName;
                try
                {
                    if (File.Exists(Form2.filePath))
                    {
                        Form2.resLabel.Text = "File already exists -- please try another name.";
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    FileStream fs = File.Create(Form2.filePath);
                    //Form2.openfileTTSL.Text = ("Currently open file: " + Form2.filePath);
                    fs.Close();
                }
                catch (Exception Ex)
                {
                    Form2 f2 = new Form2();
                    Form2.resLabel.Text = "An error occured.";
                    System.Media.SystemSounds.Hand.Play();
                }
            }
        }
    }
}
