using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualText
{
    class fileioDDBC
    {
        public void createFile()
        {
            Form2.codeEditor.Text += "\nfile.create(\"path\");";
        }

        public void createDirectory()
        {
            Form2.codeEditor.Text += "\nfolder.create(\"path\");";
        }

        public void writeFile()
        {
            Form2.codeEditor.Text += "\nfile.append(\"path\", \"data\");";
        }

        public void readFile()
        {
            Form2.codeEditor.Text += "\nfile.read(\"path\", \"line number\");";
        }
    }
}
