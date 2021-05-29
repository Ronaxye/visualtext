using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualText
{
    class basicDDBC
    {
        public void printTSMIF()
        {
            Form2.codeEditor.Text += ("print(your text here);" + "\n");
        }
        
        public void printlnTSMIF()
        {
            Form2.codeEditor.Text += ("println(your text here);" + "\n");
        }

        public void printvarTSMIF()
        {
            Form2.codeEditor.Text += ("printvar(variable name);");
        }

        public void inputTSMIF()
        {
            Form2.codeEditor.Text += ("input(type);" + "\n");
        }

        public static class mathTSMISC {
            public static void mathAdd()
            {
                Form2.codeEditor.Text += ("add(num1, num2);" + "\n");
            }
            public static void mathSub()
            {
                Form2.codeEditor.Text += ("\n" + "subtract(num1, num2);");
            }
            public static void mathMulti()
            {
                Form2.codeEditor.Text += ("\n" + "multiply(num1, num2);");
            }
            public static void mathDiv()
            {
                Form2.codeEditor.Text += ("\n" + "divide(num1, num2);");
            }
            public static void mathMod()
            {
                Form2.codeEditor.Text += ("\n" + "modulo(num1, num2);");
            }
            public static void mathSqrt()
            {
                Form2.codeEditor.Text += ("\n" + "squareRoot(num1);");
            }
            public static void mathPwr()
            {
                Form2.codeEditor.Text += ("\n" + "power(base, exponent);");
            }
        }

        public static class randomTSMISC {
            public static void randomInt()
            {
                Form2.codeEditor.Text += ("\n" + "randomInteger(min, max);");
            }
            public static void randomDec()
            {
                Form2.codeEditor.Text += ("\n" + "randomDecimal(min, max);");
            }
        }
    }
}
