using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.Model
{
    public class RayTracerModel : INotifyPropertyChanged
    {
        private string _canvasWidth;
        private string _canvasHeight;

        public string CanvasWidth
        {
            get => _canvasWidth;
            set
            {
                if(_canvasWidth != value)
                {
                    _canvasWidth = value;
                    RaisePropertyChanged("CanvasWidth");
                }
            }
        }

        public string CanvasHeight
        {
            get => _canvasHeight;
            set
            {
                if(_canvasHeight != value)
                {
                    _canvasHeight = value;
                    RaisePropertyChanged("CanvasHeight");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
