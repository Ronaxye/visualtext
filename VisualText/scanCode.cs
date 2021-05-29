using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Diagnostics;

namespace VisualText
{
    public static class scanCode
    {
        public static int lineNumber = 0;
        public static int numberOfLines = 0;
        public static int blockIndex = 0;

        public static void start()
        {
            //Form2.clearBlocks();
            saveTSMIC saveTSMICN = new saveTSMIC();
            saveTSMICN.saveTSMIF();
            DateTime curTime = DateTime.Now;
            Form2.codeOutput.Text += ("====== Running " + Form2.filePath + " at " + curTime + " ======\n");
            try
            {
                numberOfLines = File.ReadLines(Form2.filePath).Count();
                while (lineNumber <= numberOfLines)
                {
                    string curLine = File.ReadLines(Form2.filePath).Skip(lineNumber).Take(1).First();
                    determine(curLine);
                    ++lineNumber;
                }
            }
            catch (Exception Ex)
            {

            }
            Form2.codeOutput.Text += " \n=== END OF PROGRAM ===";
            Form2.codeOutput.Text += " \n";
            Form2.codeOutput.Text += " \n";
            Form2.codeOutput.Text += " \n";
            Form2.codeOutput.Text += " \n";
            lineNumber = 0;
        }

        public static void determine(string curLine)
        {
            if (curLine.StartsWith("println"))
            {
                basics.println(curLine);
            }
            else if (curLine.StartsWith("print"))
            {
                basics.print(curLine);
            }
            else if (curLine.StartsWith("input"))
            {
                basics.input(curLine);
            }
            else if (curLine.StartsWith("add"))
            {
                basics.add(curLine);
            }
            else if (curLine.StartsWith("subtract"))
            {
                basics.subtract(curLine);
            }
            else if (curLine.StartsWith("multiply"))
            {
                basics.multiply(curLine);
            }
            else if (curLine.StartsWith("divide"))
            {
                basics.divide(curLine);
            }
            else if (curLine.StartsWith("modulo"))
            {
                basics.modulo(curLine);
            }
            /*
            else if (curLine.StartsWith("squareRoot"))
            {
                basics.squareRoot(curLine);
            }
            else if (curLine.StartsWith("power"))
            {
                basics.power(curLine);
            }
            else if (curLine.StartsWith("randomInteger"))
            {
                basics.randomInteger(curLine);
            }
            else if (curLine.StartsWith("randomDecimal"))
            {
                basics.randomDecimal(curLine);
            }
            */
            //data
            else if (curLine.StartsWith("string"))
            {
                data.newString(curLine);
            }
            else if (curLine.StartsWith("int"))
            {
                data.newInt(curLine);
            }
            else if (curLine.StartsWith("long"))
            {
                data.newLong(curLine);
            }
            else if (curLine.StartsWith("double"))
            {
                data.newDouble(curLine);
            }
            else if (curLine.StartsWith("boolean"))
            {
                data.newBoolean(curLine);
            }
        }

        public static class basics
        {
            public static void print(string curLine)
            {
                curLine = curLine.Remove(0, 7);
                string newCurLine = curLine.Remove(curLine.Length - 3);
                Form2.codeOutput.Text += newCurLine;
                drawButton.print(newCurLine);
            }

            public static void println(string curLine)
            {
                curLine = curLine.Remove(0, 9);
                string newCurLine = curLine.Remove(curLine.Length - 3);
                Form2.codeOutput.Text += "\n" + newCurLine;
                drawButton.println(newCurLine);
            }

            public static void input(string curLine)
            {
                //await Task.Delay(1000);
            }

            public static void add(string curLine)
            {
                //Form2.codeEditor.Text += ("add(num1, num2);" + "\n");
                //print(add(5,10));
                curLine = curLine.Remove(0, 4);
                curLine = curLine.Remove(curLine.Length - 2);
                string[] toBeAdded = curLine.Replace(" ", "").Split(",").ToArray();
                double final = 0;
                for (int i = 0; i < toBeAdded.Length; ++i)
                {
                    final += Double.Parse(toBeAdded[i]);
                }
                Form2.codeOutput.Text += "\n" + final;
                drawButton.addB(toBeAdded);
            }

            public static void subtract(string curLine)
            {
                curLine = curLine.Remove(0, 9);
                curLine = curLine.Remove(curLine.Length - 2);
                string[] toBeSubtracted = curLine.Replace(" ", "").Split(",").ToArray();
                double final = Double.Parse(toBeSubtracted[1])-Double.Parse(toBeSubtracted[0]);
                Form2.codeOutput.Text += "\n" + final;
                drawButton.subB(toBeSubtracted);
            }

            public static void multiply(string curLine)
            {
                curLine = curLine.Remove(0, 9);
                curLine = curLine.Remove(curLine.Length - 2);
                string[] toBeMultiplied = curLine.Replace(" ", "").Split(",").ToArray();
                double final = 1;
                for(int i = 0; i < toBeMultiplied.Length; ++i)
                {
                    final *= Double.Parse(toBeMultiplied[i]);
                }
                Form2.codeOutput.Text += "\n" + final;
                drawButton.multiB(toBeMultiplied);
            }

            public static void divide(string curLine)
            {
                curLine = curLine.Remove(0, 7);
                curLine = curLine.Remove(curLine.Length - 2);
                string[] toBeDivided = curLine.Replace(" ", "").Split(",").ToArray();
                double final = Double.Parse(toBeDivided[0]) / Double.Parse(toBeDivided[1]);
                Form2.codeOutput.Text += "\n" + final;
                drawButton.divB(toBeDivided);
            }

            public static void modulo(string curLine)
            {
                curLine = curLine.Remove(0, 7);
                curLine = curLine.Remove(curLine.Length - 2);
                string[] toBeModulo = curLine.Replace(" ", "").Split(",").ToArray();
                double final = Double.Parse(toBeModulo[0]) % Double.Parse(toBeModulo[1]);
                Form2.codeOutput.Text += "\n" + final;
                drawButton.modB(toBeModulo);
            }
        }

        public static class data
        {
            public static void newString(string curLine)
            {
                string type = "string";
                curLine = curLine.Remove(0, 7);
                string[] varName = curLine.Split("=");
                varName[0].Trim();
                varName[1].Trim();
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0], finalString);
                drawButton.stringB(varName[0], varName[1]);
            }

            public static void newInt(string curLine)
            {
                string type = "int";
                curLine = curLine.Remove(0, 4);
                string[] varName = curLine.Split("=");
                varName[0].Trim();
                varName[1].Trim();
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0], finalString);
                drawButton.intB(varName[0], varName[1]);
            }

            public static void newLong(string curLine)
            {
                string type = "long";
                curLine = curLine.Remove(0, 5);
                string[] varName = curLine.Split("=");
                varName[0].Trim();
                varName[1].Trim();
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0], finalString);
                drawButton.longB(varName[0], varName[1]);
            }

            public static void newDouble(string curLine)
            {
                string type = "double";
                curLine = curLine.Remove(0, 7);
                string[] varName = curLine.Split("=");
                varName[0].Trim();
                varName[1].Trim();
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0], finalString);
                drawButton.doubleB(varName[0], varName[1]);
            }

            public static void newBoolean(string curLine)
            {
                string type = "boolean";
                curLine = curLine.Remove(0, 8);
                string[] varName = curLine.Split("=");
                varName[0].Trim();
                varName[1].Trim();
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0], finalString);
                drawButton.booleanB(varName[0], varName[1]);
            }
        }

        public static class drawButton
        {
            static double resized25a = (Form2.resX * 0.25);
            static int resized25 = (int)resized25a;
            static double resized75a = (Form2.resX * 0.75);
            static int resized75 = (int)resized75a;

            public static void print(string newCurLine)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 30);
                newBlock.Text = ("Output " + newCurLine);
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                ++blockIndex;
            }
            public static void println(string newCurLine)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 30);
                newBlock.Text = ("Output " + newCurLine + " to a new line");
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                ++blockIndex;
            }

            public static void addB(string[] aBunchOfVariables)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Add ");
                for (int i = 0; i < aBunchOfVariables.Length; ++i)
                {
                    newBlock.Text += aBunchOfVariables[i].ToString() + ", ";
                    if (i == 3)
                    {
                        newBlock.Text += "\n";
                    }
                }
                newBlock.Text += ("\n together");
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                blockIndex += 2;
            }

            public static void subB(string[] aBunchOfVariables)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 30);
                newBlock.Text = ("Subtract " + aBunchOfVariables[0] + " from " + aBunchOfVariables[1]);
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                ++blockIndex;
            }

            public static void multiB(string[] aBunchOfVariables)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Multiply ");
                for (int i = 0; i < aBunchOfVariables.Length; ++i)
                {
                    newBlock.Text += aBunchOfVariables[i].ToString() + ", ";
                    if (i == 3)
                    {
                        newBlock.Text += "\n";
                    }
                }
                newBlock.Text += ("\n together");
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                ++blockIndex;
            }

            public static void divB(string[] aBunchOfVariables)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 30);
                newBlock.Text = ("Divide " + aBunchOfVariables[0] + " by " + aBunchOfVariables[1]);
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                ++blockIndex;
            }

            public static void modB(string[] aBunchOfVariables)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 30);
                newBlock.Text = ("Get " + aBunchOfVariables[0] + " modulo " + aBunchOfVariables[1]);
                newBlock.Font = new Font("Bahnschrift", 12);
                Form2.blocks.AddLast(newBlock);
                ++blockIndex;
            }

            public static void stringB(string index1, string index2)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Create a string called " + index1 + "\n and set its value to "  + index2);
                newBlock.Font = new Font("Bahnschrift", 10);
                Form2.blocks.AddLast(newBlock);
                blockIndex += 2;
            }

            public static void intB(string index1, string index2)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Create an integer called " + index1 + "\n and set its value to " + index2);
                newBlock.Font = new Font("Bahnschrift", 10);
                Form2.blocks.AddLast(newBlock);
                blockIndex += 2;
            }

            public static void longB(string index1, string index2)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Create a big int called " + index1 + "\n and set its value to " + index2);
                newBlock.Font = new Font("Bahnschrift", 10);
                Form2.blocks.AddLast(newBlock);
                blockIndex += 2;
            }

            public static void doubleB(string index1, string index2)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Create a double called " + index1 + "\n and set its value to " + index2);
                newBlock.Font = new Font("Bahnschrift", 10);
                Form2.blocks.AddLast(newBlock);
                blockIndex += 2;
            }

            public static void booleanB(string index1, string index2)
            {
                Button newBlock = new Button();
                newBlock.Location = new Point((resized75 + 12), (70 + (scanCode.blockIndex * 30)));
                newBlock.Size = new Size((resized25 - 50), 60);
                newBlock.Text = ("Create a boolean called " + index1 + "\n and set its value to " + index2);
                newBlock.Font = new Font("Bahnschrift", 10);
                Form2.blocks.AddLast(newBlock);
                blockIndex += 2;
            }
        }
    }
}
