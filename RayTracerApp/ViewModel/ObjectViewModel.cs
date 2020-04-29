using RayTracerApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerApp.ViewModel
{
    public class ObjectViewModel
    {
        public ObservableCollection<ObjectModel> objects { get; set; }

        public ObjectViewModel()
        {
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            ObservableCollection<ObjectModel> defaultObjejcts = new ObservableCollection<ObjectModel>();
            //new RayTracerLib.Sphere(100.0, 100.0, 0.0, 40.0, new RayTracerLib.Color(250.0, 0.0, 50.0))
            defaultObjejcts.Add(new ObjectModel { Radius = 40.0, X = 100.0, Y = 100.0, Z = 0.0 });
            objects = defaultObjejcts;
        }
    }
}
