using System;
using System.Collections.Generic;
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

namespace RayTracerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void PlaneGrid_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as DataGrid).Columns[0].Header = "Normal Vector X";
            (sender as DataGrid).Columns[1].Header = "Normal Vector Y";
            (sender as DataGrid).Columns[2].Header = "Normal Vector Z";
            (sender as DataGrid).Columns[3].Header = "Point X";
            (sender as DataGrid).Columns[4].Header = "Point Y";
            (sender as DataGrid).Columns[5].Header = "Point Z";
            (sender as DataGrid).Columns[6].Header = "Color";
            //TODO-create helper string function-create Header text from a property name (nameof(item)).SplitByUpperCaseLetter, use
            //foreach loop (or for loop (below)) to set
            //TODO-bind column width to the length of header text from previous TODO
            //var names = new MainViewModel().Planes;
            //for (int i = 0; i < names.Count; i++)
            //{
            //    var item = names[i];
            //    (sender as DataGrid).Columns[i].Header = nameof(item);
            //}
        }
    }
}
