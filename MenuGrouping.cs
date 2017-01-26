using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Library
{
    public class MenuGrouping<K,T>:ObservableCollection<T>
    {
        public K Key { get; private set; }
        public MenuGrouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach(var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
