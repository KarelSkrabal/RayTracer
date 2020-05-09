using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayTracerLib;

namespace RayTracerWPF.Model
{
    public class DataItem
    {
        public IRaTracer RayTracer { get; private set; }
        public string Title
        {
            get;
            private set;
        }

        public double CanvasWidth { get; private set; }

        public DataItem(/*string title, double canvasWidth,*/ IRaTracer rayTracer)
        {
            RayTracer = rayTracer;
            //Title = title;
            //CanvasWidth = canvasWidth;
        }
    }
}
