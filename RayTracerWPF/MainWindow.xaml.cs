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

            var columWidth = (sender as DataGrid).ActualWidth / 7;
            (sender as DataGrid).Columns[0].Width = columWidth;
            (sender as DataGrid).Columns[1].Width = columWidth;
            (sender as DataGrid).Columns[2].Width = columWidth;
            (sender as DataGrid).Columns[3].Width = columWidth;
            (sender as DataGrid).Columns[4].Width = columWidth;
            (sender as DataGrid).Columns[5].Width = columWidth;
            (sender as DataGrid).Columns[6].Width = columWidth;
        }

        private void grdTriangles_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as DataGrid).Columns[0].Header = "Vertex1 X";
            (sender as DataGrid).Columns[1].Header = "Vertex1 Y";
            (sender as DataGrid).Columns[2].Header = "Vertex1 Z";
            (sender as DataGrid).Columns[3].Header = "Vertex2 X";
            (sender as DataGrid).Columns[4].Header = "Vertex2 Y";
            (sender as DataGrid).Columns[5].Header = "Vertex2 Z";
            (sender as DataGrid).Columns[6].Header = "Vertex3 X";
            (sender as DataGrid).Columns[7].Header = "Vertex3 Y";
            (sender as DataGrid).Columns[8].Header = "Vertex3 Z";
            (sender as DataGrid).Columns[9].Header = "Color";

            var columWidth = (sender as DataGrid).ActualWidth / 9;
            (sender as DataGrid).Columns[0].Width = columWidth;
            (sender as DataGrid).Columns[1].Width = columWidth;
            (sender as DataGrid).Columns[2].Width = columWidth;
            (sender as DataGrid).Columns[3].Width = columWidth;
            (sender as DataGrid).Columns[4].Width = columWidth;
            (sender as DataGrid).Columns[5].Width = columWidth;
            (sender as DataGrid).Columns[6].Width = columWidth;
            (sender as DataGrid).Columns[7].Width = columWidth;
            (sender as DataGrid).Columns[8].Width = columWidth;
        }

        private void grdSpheres_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as DataGrid).Columns[1].Header = "Center X";
            (sender as DataGrid).Columns[2].Header = "Center Y";
            (sender as DataGrid).Columns[3].Header = "Center Z";
            (sender as DataGrid).Columns[4].Header = "Color";

            var columWidth = (sender as DataGrid).ActualWidth / 4;
            (sender as DataGrid).Columns[0].Width = columWidth;
            (sender as DataGrid).Columns[1].Width = columWidth;
            (sender as DataGrid).Columns[2].Width = columWidth;
            (sender as DataGrid).Columns[3].Width = columWidth;
            (sender as DataGrid).Columns[4].Width = columWidth;
        }
    }
}
