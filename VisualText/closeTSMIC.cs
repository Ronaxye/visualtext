using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualText
{
    public static class closeTSMIC
    {
        public static void closeTSMIF()
        {
            Form2.codeEditor.Text = "";
            Form2.codeOutput.Text = "";
            Form2.openfileTTSL.Text = "";
            //
            if (Form2.filePath.Equals(""))
            {
                saveTSMIC saveTSMICN = new saveTSMIC();
                saveTSMICN.saveTSMIF();
            }
            //
            for (int i = 0; i < Form2.blocks.Count(); ++i)
            {
                Form2.blocks.ElementAt(i).Visible = false;
            }
            Form2.blocks.Clear();
        }
    }
}
