using System.Collections.ObjectModel;

namespace RayTracerWPF.Model
{
    public interface IDataProvider
    {
        ObservableCollection<Plane> _planes { get; set; }
        ObservableCollection<Sphere> _spheres { get; set; }
        ObservableCollection<Triangle> _triangles { get; set; }
        Scene _scene { get; set; }
        void Run();
    }
}