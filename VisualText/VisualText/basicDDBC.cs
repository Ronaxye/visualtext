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
            Form2.codeEditor.Text += ("\nprint(your text here);");
        }
        
        public void printlnTSMIF()
        {
            Form2.codeEditor.Text += ("\nprintln(your text here);");
        }

        public void printvarTSMIF()
        {
            Form2.codeEditor.Text += ("\nprintvar(variable name);");
        }

        public void inputTSMIF()
        {
            Form2.codeEditor.Text += ("\ninput(type);");
        }

        public static class mathTSMISC {
            public static void mathAdd()
            {
                Form2.codeEditor.Text += ("\nadd(num1, num2);");
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
