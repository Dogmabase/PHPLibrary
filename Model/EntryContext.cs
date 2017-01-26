using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Library.Model
{
    class EntryContext : DbContext
    {
        public EntryContext() : base("EntryContext")        {        }
        public DbSet<Entry> entries { get; set; }
    }
}
