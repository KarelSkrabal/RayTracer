using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.Model
{
    public class DataItem
    {
        internal ObservableCollection<Plane> _planes { get; set; }
        internal ObservableCollection<Sphere> _spheres { get; set; }
        internal ObservableCollection<Triangle> _triangles { get; set; }
        internal Scene _scene { get; set; }

        public DataItem(ObservableCollection<Plane> planes, ObservableCollection<Sphere> spheres, ObservableCollection<Triangle> triangles, Scene scene)
        {
            _planes = planes;
            _spheres = spheres;
            _triangles = triangles;
            _scene = scene;
        }
    }
}
