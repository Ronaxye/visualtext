using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualText
{
    class logicDDBC
    {
        public void forTSMIF()
        {
            Form2.codeEditor.Text += ("\nfor i in range (min, max) :: function 1 : function 2 : function 3 : etc");
        }

        public void whileTSMIF()
        {
            Form2.codeEditor.Text += ("\nwhile (argument) :: function 1 : function 2 : function 3 : etc");
        }
    }
}
