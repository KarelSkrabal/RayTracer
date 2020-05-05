using RayTracerWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.ViewModel
{
    public class RayTracerViewModel : INotifyPropertyChanged
    {
        private RayTracerModel _rayTracer;
        public RayTracerModel RayTracer
        {
            get => _rayTracer;
            set {
                _rayTracer = value;
                OnPropertyChanged("RayTracer");
            }
        }
        public RayTracerViewModel()
        {
            LoadRayTracer();
        }

        public void LoadRayTracer()
        {
            var rayTracer = new RayTracerModel()
            {
                CanvasWidth = "10",
                CanvasHeight = "20"
            };
            RayTracer = rayTracer;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
