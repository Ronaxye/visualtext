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
            Form2.codeEditor.Text += ("string variableName = value;" + "\n");
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
            Form2.codeEditor.Text += ("int variableName = value;" + "\n");
        }

        public static void newLong()
        {
            Form2.codeEditor.Text += ("long variableName = value;" + "\n");
        }

        public static void newDouble()
        {
            Form2.codeEditor.Text += ("double variableName = value;" + "\n");
        }

        public static void newBoolean()
        {
            Form2.codeEditor.Text += ("boolean variableName = value;" + "\n");
        }
        public static void newArray()
        {
            Form2.codeEditor.Text += ("type[numberOfSlots] arrayName;" + "\n");
            Form2.codeEditor.Text += ("arrayName[slotNumber] = value;" + "\n");
        }

        public static class newLinkedList {
            public static void create() {
                Form2.codeEditor.Text += ("LinkedList<type> listName;" + "\n");
            }
            public static void add()
            {
                Form2.codeEditor.Text += ("listName.add(data/variable of matching type);" + "\n");
            }
            public static void readIndex()
            {
                Form2.codeEditor.Text += ("listName.read(slotNumber);" + "\n");
            }
            public static void removeIndex()
            {
                Form2.codeEditor.Text += ("listName.remove(slotNumber);" + "\n");
            }
        }

        public static class newDictionary {
            public static void create() {
                Form2.codeEditor.Text += ("Dictionary<type> dictionaryName;");
            }

            public static void addPair()
            {
                Form2.codeEditor.Text += ("dictionaryName.add(key/word, value/definition);");
            }

            public static void getValue()
            {
                Form2.codeEditor.Text += ("dictionaryName.getValue(key);");
            }

            public static void removePair()
            {
                Form2.codeEditor.Text += ("dictionaryName.remove(key);");
            }
        }
    }
}
