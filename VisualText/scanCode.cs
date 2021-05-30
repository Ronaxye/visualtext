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
        public static bool isInsideForLoop = false;
        public static bool isWaitingForInput = false;
        private static string inputType = "";
        private static string inputContent = "";
        private static string inputVarName = "";

        //original.SplitByFirst("keyword");
        /*
        public static string[] SplitByFirst(this string original, string keyword)
        {
            string[] result = new string[2];
            string aVariable = original;
            for (int i = 0; i < original.Length; ++i)
            {
                if (aVariable.StartsWith(keyword))
                {
                    result[0] = original.Substring(0, i);
                    result[1] = original.Remove(0, i);
                    break;
                }
                else
                {
                    aVariable.Remove(0, 1);
                }
            }

            return result;
        }
        */

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
            else if (curLine.StartsWith("printvar"))
            {
                basics.printvar(curLine);
            }
            else if (curLine.StartsWith("print"))
            {
                basics.print(curLine);
            }
            else if (curLine.StartsWith("input"))
            {
                //
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
            else if (curLine.StartsWith("for"))
            {
                logic.newFor(curLine);
            }
            else if (curLine.StartsWith("while"))
            { 
                logic.newWhile(curLine);
            }
            else if (curLine.StartsWith("file") || curLine.StartsWith("folder"))
            {
                file.determine(curLine);
            }
            else if (curLine.StartsWith("ui"))
            {

            }
            else if (curLine.StartsWith("mars"))
            {
                if (curLine.Contains("ping"))
                {
                    drawButton.mars();
                }
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

            public static void printvar(string curLine)
            {
                curLine = curLine.Replace(" ", "");
                curLine = curLine.Remove(0, 9);
                string newCurLine = curLine.Remove(curLine.Length - 2);
                string getVariable = Form2.storedVariables[newCurLine];
                Debug.WriteLine(getVariable);
                if (getVariable.StartsWith("string"))
                {
                    getVariable = getVariable.Remove(0, 7);
                }
                else if (getVariable.StartsWith("int"))
                {
                    getVariable = getVariable.Remove(0, 4);
                }
                else if (getVariable.StartsWith("long"))
                {
                    getVariable = getVariable.Remove(0, 5);
                }
                else if (getVariable.StartsWith("double"))
                {
                    getVariable = getVariable.Remove(0, 7);
                }
                else if (getVariable.StartsWith("boolean"))
                {
                    getVariable = getVariable.Remove(0, 8);
                }
                getVariable = getVariable.Substring(2);
                getVariable = getVariable.Remove(getVariable.Length - 2);
                Form2.codeOutput.Text += "\n" + (getVariable.Trim());
                drawButton.printvar(newCurLine);
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
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0].Trim(), finalString.Trim());
                drawButton.stringB(varName[0], varName[1]);
            }

            public static void newInt(string curLine)
            {
                string type = "int";
                curLine = curLine.Remove(0, 4);
                string[] varName = curLine.Split("=");
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0].Trim(), finalString.Trim());
                drawButton.intB(varName[0], varName[1]);
            }

            public static void newLong(string curLine)
            {
                string type = "long";
                curLine = curLine.Remove(0, 5);
                string[] varName = curLine.Split("=");
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0].Trim(), finalString.Trim());
                drawButton.longB(varName[0], varName[1]);
            }

            public static void newDouble(string curLine)
            {
                string type = "double";
                curLine = curLine.Remove(0, 7);
                string[] varName = curLine.Split("=");
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0].Trim(), finalString.Trim());
                drawButton.doubleB(varName[0], varName[1]);
            }

            public static void newBoolean(string curLine)
            {
                string type = "boolean";
                curLine = curLine.Remove(0, 8);
                string[] varName = curLine.Split("=");
                string finalString = (type + "-" + varName[1]);
                Form2.storedVariables.Add(varName[0].Trim(), finalString.Trim());
                drawButton.booleanB(varName[0], varName[1]);
            }
        }

        public static class logic
        {
            public static void newFor(string curLine)
            {
                //for i in range (3, 7) :: func1(); : func2(); : func3();
                
                // a ||  b  : c : d

                string[] PARAMETERS_CODETOLOOP = curLine.Split("::");
                PARAMETERS_CODETOLOOP[0].Trim();
                string[] MULTIPLE_FUNCTIONS = PARAMETERS_CODETOLOOP[1].Split(":");

                PARAMETERS_CODETOLOOP[0].Replace("for", "");
                PARAMETERS_CODETOLOOP[0].Replace("in", "");
                PARAMETERS_CODETOLOOP[0].Replace("range", "");
                PARAMETERS_CODETOLOOP[0].Replace(" ", "");

                //scanCode.determine(PARAMETERS_CODETOLOOP[1].Trim());
                //Debug.WriteLine(PARAMETERS_CODETOLOOP[1].Trim());

                string[] VARNAME_CONSTRAINTS = PARAMETERS_CODETOLOOP[0].Split("(");
                VARNAME_CONSTRAINTS[1] = VARNAME_CONSTRAINTS[1].Replace(")", "");
                string[] MIN_MAX = VARNAME_CONSTRAINTS[1].Split(",");
                int min = int.Parse(MIN_MAX[0]);
                int max = int.Parse(MIN_MAX[1]);
                int timesToLoop = max - min + 1;

                Debug.WriteLine(min + " " + max + " " + timesToLoop + " " + PARAMETERS_CODETOLOOP[1].Trim());

                isInsideForLoop = true;
                for (int i = 0; i < timesToLoop; ++i)
                {
                    for (int ii = 0; ii < MULTIPLE_FUNCTIONS.Length; ++ii)
                    {
                        scanCode.determine(MULTIPLE_FUNCTIONS[ii].Trim());
                    }
                }
                isInsideForLoop = false;

                drawButton.forB(timesToLoop, MULTIPLE_FUNCTIONS);




                /*
                string[] seperatedA = curLine.Split(":").ToArray();    // A[0 // 1] [ for (int i = 0, i < 10, ++i // println("h i"); );]
                seperatedA[0].Replace(" ", "").Remove(0, 4).Trim();    // A[0 // 1] [inti=0,i<10,++i// println("h i"); );]
                seperatedA[1].Remove(seperatedA[1].Length - 2).Trim(); // A[0 // 1] [inti=0,i<10,++i//println("h i");] //END RESULT
                string[] seperatedB = seperatedA[0].Split(",").ToArray(); // B [0 // 1 // 2] [inti=0//i<10//++i]
                string type;
                if (seperatedB[0].StartsWith("int"))
                {
                    type = "int";
                    seperatedB[0] = seperatedB[0].Remove(0, 3); // B [0 // 1 // 2] [i=0//i<10//++i]
                }
                else if (seperatedB[0].StartsWith("double"))
                {
                    type = "double";
                    seperatedB[0] = seperatedB[0].Remove(0, 6);
                }
                
                string[] temp = seperatedB[0].Split("=").ToArray(); // temp [0 // 1] [i//0]
                string varName = temp[0];
                double startNum = double.Parse(temp[1]);
                double constraint = double.Parse(seperatedB[1].Remove(0, varName.Length)); // B [0 // 1 // 2] [i=0//<10//++i]
                double interval = 0;

                if (seperatedB[2].Contains("++"))
                {
                    interval = 1.0;
                }
                else if (seperatedB[2].Contains("--"))
                {
                    interval = -1.0;
                }
                else if (seperatedB[2].Contains("+="))
                {
                    interval = double.Parse(seperatedA[2].Remove(0, varName.Length).Replace("+=", ""));
                }
                else if (seperatedB[2].Contains("-="))
                {
                    interval = 0 - double.Parse(seperatedA[2].Remove(0, varName.Length).Replace("-=", ""));
                }
                
                for (double i = startNum; i < constraint; i += interval)
                {
                    scanCode.determine(seperatedA[1]);
                }
                */
            }

            public static void newWhile(string curLine)
            {
                string[] PARAMETERS_CODETOLOOP = curLine.Split("::");
                PARAMETERS_CODETOLOOP[0].Trim();
                string[] MULTIPLE_FUNCTIONS = PARAMETERS_CODETOLOOP[1].Split(":");

                isInsideForLoop = true;
                //might wanna fix this btw
                for (int i = 0; i < MULTIPLE_FUNCTIONS.Length; ++i)
                {
                    scanCode.determine(MULTIPLE_FUNCTIONS[i].Trim());
                }
                isInsideForLoop = false;

                drawButton.whileB(PARAMETERS_CODETOLOOP[0].Replace("while ", "").Trim(), MULTIPLE_FUNCTIONS, curLine);
            }

        }

        public static class file
        {
            public static void determine(string curLine)
            {
                if (curLine.StartsWith("file.create"))
                {
                    curLine = curLine.Remove(0, 13);
                    curLine = curLine.Remove(curLine.Length - 3);
                    Debug.WriteLine(curLine);
                    create(curLine);
                }
                else if (curLine.StartsWith("file.append"))
                {
                    curLine = curLine.Remove(0, 13);
                    curLine = curLine.Remove(curLine.Length - 3);
                    Debug.WriteLine(curLine);
                    append(curLine);
                }

                else if (curLine.StartsWith("file.read"))
                {
                    curLine = curLine.Remove(0, 11);
                    curLine = curLine.Remove(curLine.Length - 3);
                    Debug.WriteLine(curLine);
                    read(curLine);
                }
                else if (curLine.StartsWith("folder.create"))
                {
                    curLine = curLine.Remove(0, 15);
                    curLine = curLine.Remove(curLine.Length - 3);
                    Debug.WriteLine(curLine);
                    folder(curLine);
                }
            }

            public static void create(string path)
            {
                Debug.WriteLine(path);
                try
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                    
                }
                catch (Exception Ex)
                {
                    Form2.codeOutput.Text += "\nError occured creating file " + path;
                }
                drawButton.createFileB(path);
            }

            public static void append(string path)
            {
                string[] splitted = path.Split(",");
                splitted[0] = splitted[0].Replace("\"", "");
                //splitted[0] = splitted[0].Remove(splitted[0].Length - 1);
                splitted[1] = splitted[1].Remove(0, 2);
                //splitted[1] = splitted[1].Remove(splitted[1].Length - 1);
                Debug.WriteLine(splitted[0] + " " + splitted[1]);
                try
                {
                    StreamWriter sw = File.AppendText(splitted[0]);
                    sw.WriteLine(splitted[1]);
                    sw.Close();
                }
                catch (Exception Ex)
                {
                    Form2.codeOutput.Text += "\nError occured writing to file " + path;
                }
                drawButton.writeFileB(splitted[1], splitted[0]);

            }

            public static void read(string path)
            {
                string[] splitted = path.Split(",");
                splitted[0] = splitted[0].Replace("\"", "");
                splitted[1] = splitted[1].Trim().Remove(0, 1);
                splitted[1] = splitted[1].Replace(" ", "");
                int lineNumber = int.Parse(splitted[1]) - 1;
                Debug.WriteLine(splitted[0] + " " + splitted[1]);
                try
                {
                    Form2.codeOutput.Text += "\n" + File.ReadLines(splitted[0]).Skip(lineNumber).Take(1).First();
                }
                catch (Exception Ex)
                {
                    Form2.codeOutput.Text += "\nError occured reading from file " + path;
                }
                drawButton.readFileB(lineNumber.ToString(), splitted[0]);
            }

            public static void folder(string path)
            {
                Debug.WriteLine(path);
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception Ex)
                {

                }
                drawButton.createFolderB(path);
            }
        }
        //public 

        public static class drawButton
        {
            static double resized25a = (Form2.resX * 0.25);
            static int resized25 = (int)resized25a;
            static double resized75a = (Form2.resX * 0.75);
            static int resized75 = (int)resized75a;

            public static void print(string newCurLine)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Output " + newCurLine);
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }
            public static void println(string newCurLine)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Output " + newCurLine + " to a new line");
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void printvar(string newCurLine)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Output value of " + newCurLine);
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void inputB(string TYPE, string VAR_NAME)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Get a " + TYPE +  " from the user and\n store it to " + VAR_NAME);
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                    //return 1;
                }
                //return 0;
            }

            public static void addB(string[] aBunchOfVariables)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
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
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void subB(string[] aBunchOfVariables)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Subtract " + aBunchOfVariables[0] + " from " + aBunchOfVariables[1]);
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void multiB(string[] aBunchOfVariables)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
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
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void divB(string[] aBunchOfVariables)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Divide " + aBunchOfVariables[0] + " by " + aBunchOfVariables[1]);
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void modB(string[] aBunchOfVariables)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Get " + aBunchOfVariables[0] + " modulo " + aBunchOfVariables[1]);
                    newBlock.Font = new Font("Bahnschrift", 12);
                    newBlock.BackColor = ColorTranslator.FromHtml("#1f7a20");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void stringB(string index1, string index2)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Create a string called " + index1 + "\n and set its value to " + index2);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void intB(string index1, string index2)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Create an integer called " + index1 + "\n and set its value to " + index2);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void longB(string index1, string index2)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Create a big int called " + index1 + "\n and set its value to " + index2);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void doubleB(string index1, string index2)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Create a double called " + index1 + "\n and set its value to " + index2);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void booleanB(string index1, string index2)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Create a boolean called " + index1 + "\n and set its value to " + index2);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void forB(int numOfTimesToRun, string[] aBunchOfVariables)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = "";
                    for (int i = 0; i < aBunchOfVariables.Length; ++i)
                    {
                        newBlock.Text += aBunchOfVariables[i].ToString() + ", ";
                        if (i == 2)
                        {
                            newBlock.Text += "\n";
                        }
                    }
                    newBlock.Text += numOfTimesToRun + " times";
                    newBlock.BackColor = ColorTranslator.FromHtml("#a108c7");
                    newBlock.Font = new Font("Bahnschrift", 10);
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void whileB(string whileParam, string[] aBunchOfVariables, string curLine)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = "While " + whileParam + ", run";
                    for (int i = 0; i < aBunchOfVariables.Length; ++i)
                    {
                        newBlock.Text += aBunchOfVariables[i].ToString() + ", ";
                        if (i == 2)
                        {
                            newBlock.Text += "\n";
                        }
                    }
                    newBlock.BackColor = ColorTranslator.FromHtml("#a108c7");
                    newBlock.Font = new Font("Bahnschrift", 10);
                    Form2.blocks.AddLast(newBlock);
                    Debug.WriteLine("2456789");
                    blockIndex += 2;
                }
            }

            public static void createFileB(string path)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Create a file at " + path);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void createFolderB(string path)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 30);
                    newBlock.Text = ("Create a folder at " + path);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    ++blockIndex;
                }
            }

            public static void writeFileB(string data, string path)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Write " + data + " to\n" + path);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void readFileB(string lineN, string path)
            {
                if (!isInsideForLoop)
                {
                    Button newBlock = new Button();
                    newBlock.Location = new Point((resized75 + 12), (90 + (scanCode.blockIndex * 30)));
                    newBlock.Size = new Size((resized25 - 50), 60);
                    newBlock.Text = ("Read line " + lineN + " from\n" + path);
                    newBlock.Font = new Font("Bahnschrift", 10);
                    newBlock.BackColor = ColorTranslator.FromHtml("#001fbd");
                    Form2.blocks.AddLast(newBlock);
                    blockIndex += 2;
                }
            }

            public static void mars()
            {
                Form2.codeOutput.Text += ("dab.mars(thingy) = stuff.(MARS_GET_IN_VC)    --thing 2021");
                Form2.codeOutput.Text += ("Penguin was never in vc, and Mars doesn't respond to pings  --thingy 2021");
                Form2.codeOutput.Text += ("Mars kept eating raw stuff and goes away for like 2 hours");
                Form2.codeOutput.Text += ("Chris said \"this\" and not anything specific");
                Form2.codeEditor.Text += ("note from Chris, when i say \"this\" i mean the keyword \"this\", for example, \"this.Form2.Visible = true;\"");
                easterEgg easterEgg = new easterEgg();
                easterEgg.Show();
            }
        }
    }
}
