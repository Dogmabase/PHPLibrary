using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Library
{
    public class EntryFileSource
    {

        private Entry entry;
        private List<Entry> entryList = new List<Entry>();
        public EntryFileSource()
        {
            ReadFile();
        }

        public void ReadFile()
        {
            string line = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader("PHPentries.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();
                        var splitLine = line.Split('~');
                        entry = new Entry(splitLine[0], splitLine[1]);
                        entryList.Add(entry);
                    }
                    //entry = new Entry(line.Substring(0, line.IndexOf('.')), line.Substring(line.IndexOf('.'), line.Length - 1));
                }
            }
            catch
            {
                Console.WriteLine("Could not read file, or other error.");
            }
        }

        public IEnumerable<Entry> GetList()
        {
            return entryList;
        }




    }
}
