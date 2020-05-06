using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.Model
{
    public class DataItem
    {
        public string Title
        {
            get;
            private set;
        }

        public double CanvasWidth { get; private set; }

        public DataItem(string title, double canvasWidth)
        {
            Title = title;
            CanvasWidth = canvasWidth;
        }
    }
}
