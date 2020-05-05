using RayTracerWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.ViewModel
{
    public class RayTracerViewModel /*: INotifyPropertyChanged*/
    {
        public ObservableCollection<RayTracerModel> RayTracerData
        {
            get;
            set;
        }
        //private RayTracerModel _rayTracer;
        //public RayTracerModel RayTracer
        //{
        //    get => _rayTracer;
        //    set {
        //        _rayTracer = value;
        //        OnPropertyChanged("RayTracer");
        //    }
        //}
        public RayTracerViewModel()
        {
            LoadRayTracer();
        }

        public void LoadRayTracer()
        {
            ObservableCollection<RayTracerModel> rayTracerModelData = new ObservableCollection<RayTracerModel>();

            var rayTracer = new RayTracerModel()
            {
                CanvasWidth = "10",
                CanvasHeight = "20",
                LightPositionX = "20",
                LightPositionY = "30",
                LightPositionZ = "40",
                LightDirectionX = "50",
                LightDirectionY = "60",
                LightDirectionZ = "70",
                CameraPositionX = "80",
                CameraPositionY = "90",
                CameraPositionZ = "100"
            };
            rayTracerModelData.Add(rayTracer);
            this.RayTracerData = rayTracerModelData;
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
