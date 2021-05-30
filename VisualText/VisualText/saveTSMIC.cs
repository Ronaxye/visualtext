using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualText
{
    class saveTSMIC
    {
        public void saveTSMIF()
        {
            if (!File.Exists(Form2.filePath))
            {
                if (!File.Exists(Form2.filePath)) {
                    Form2.resLabel.Text = "File not found -- creating file and saving.";
                    newTSMIC newTSMIC = new newTSMIC();
                    newTSMIC.newTSMIF();
                    saveTSMIF();
                }
            }
            else
            {
                try {
                    File.WriteAllText(Form2.filePath, String.Empty);
                    Form2.codeEditor.SaveFile(Form2.filePath, RichTextBoxStreamType.PlainText);
                    displaySaved();
                } catch (Exception Ex)
                {

                }
            }
        }

        public async void displaySaved() {
            //Form2.openfileTTSL.Text = ("[ SAVED ] Currently open file: " + Form2.filePath);
            await Task.Delay(5000);
            //Form2.openfileTTSL.Text = ("Currently open file: " + Form2.filePath);
        }
    }
}
