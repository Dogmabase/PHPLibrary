using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace PHP_Library
{
    public class Entry
    {
        //public int ID { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public Entry()        {        }

        public Entry(string desc, string ctnt)
        {
            Description = desc;
            Content = ctnt;
        }

    }
}
