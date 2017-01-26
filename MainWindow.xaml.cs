using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PHP_Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EntryFileSource fileSource;
        public ObservableCollection<Entry> EntryList { get; set; }

        public ObservableCollection<MenuGrouping<string, Entry>> EntryMenuGroup;

        public MainWindow()
        {
            InitializeComponent();           

            fileSource = new EntryFileSource();
            fileSource.ReadFile();
            EntryList = new ObservableCollection<Entry>(fileSource.GetList());
            SortGroup();

            this.DataContext = this;
            Controls.GroupMenuControl groupMenuControl = new Controls.GroupMenuControl();
            groupMenuControl.DataContext = this;
            Controls.MainDisplayControl mainDisplayControl = new Controls.MainDisplayControl();
            mainDisplayControl.DataContext = this;
        }

        private void SortGroup()
        {
            var sorted = from e in EntryList
                         orderby e.Description
                         group e by e.Description[0].ToString()
                         into theGroup
                         select new MenuGrouping<string, Entry>(theGroup.Key, theGroup);
            EntryMenuGroup = new ObservableCollection<MenuGrouping<string, Entry>>(sorted);
        }

        private void ckbSearchDesc_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ckbSearchCont_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
