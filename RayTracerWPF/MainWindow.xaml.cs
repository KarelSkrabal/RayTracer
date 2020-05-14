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

namespace RayTracerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void grdPlanes_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as DataGrid).Columns[0].Header = "Normal Vector X";
            (sender as DataGrid).Columns[1].Header = "Normal Vector Y";
            (sender as DataGrid).Columns[2].Header = "Normal Vector Z";
            (sender as DataGrid).Columns[3].Header = "Point X";
            (sender as DataGrid).Columns[4].Header = "Point Y";
            (sender as DataGrid).Columns[5].Header = "Point Z";
            (sender as DataGrid).Columns[6].Header = "Color";
        }

        private void grdTriangles_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void grdSpheres_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
