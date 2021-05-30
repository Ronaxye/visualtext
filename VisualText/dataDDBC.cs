using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualText
{
    class dataDDBC
    {
        public static void newString() {
            Form2.codeEditor.Text += ("\n" + "string variableName = value;");
        }

        /*
        string name = "chris";
        int x = 1;
        int y = 2;

        
          key: string-name   v: "chris"
          key: int-x    v: 1
          
          linkedlist variablename
          linkedlist storedvalue
          
          
          hashmap
          hashmap.addKey("int");
          hashmap.addKey("string");
          hashmap.add(string, name-chris)
          hashmap.add(int, x-1)
          hashmap.add(int, y-2)
          hashmap: {string:name-chris
                    int:x-1, y-2
                    }
          
          
         
         string, int, double, boolean, long
         */

        public static void newInt()
        {
            Form2.codeEditor.Text += ("\nint variableName = value;");
        }

        public static void newLong()
        {
            Form2.codeEditor.Text += ("\nlong variableName = value;");
        }

        public static void newDouble()
        {
            Form2.codeEditor.Text += ("\ndouble variableName = value;");
        }

        public static void newBoolean()
        {
            Form2.codeEditor.Text += ("\nboolean variableName = value;");
        }
        public static void newArray()
        {
            Form2.codeEditor.Text += ("\ntype[numberOfSlots] arrayName;");
            Form2.codeEditor.Text += ("\narrayName[slotNumber] = value;");
        }

        public static class newLinkedList {
            public static void create() {
                Form2.codeEditor.Text += ("\nLinkedList<type> listName;");
            }
            public static void add()
            {
                Form2.codeEditor.Text += ("\nlistName.add(data/variable of matching type);");
            }
            public static void readIndex()
            {
                Form2.codeEditor.Text += ("\nlistName.read(slotNumber);");
            }
            public static void removeIndex()
            {
                Form2.codeEditor.Text += ("\nlistName.remove(slotNumber);");
            }
        }

        public static class newDictionary {
            public static void create() {
                Form2.codeEditor.Text += ("\nDictionary<type> dictionaryName;");
            }

            public static void addPair()
            {
                Form2.codeEditor.Text += ("\n.add(key/word, value/definition);");
            }

            public static void getValue()
            {
                Form2.codeEditor.Text += ("\ndictionaryName.getValue(key);");
            }

            public static void removePair()
            {
                Form2.codeEditor.Text += ("\ndictionaryName.remove(key);");
            }
        }
    }
}
