using RayTracerApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayTracerLib;

namespace RayTracerApp1.Presenters
{
    public class Presenter
    {
        private IView _view;
        private IRaTracer _rayTracer;

        private string Color { get; set; }  //check if get is needed

        public Presenter(IView view, IRaTracer rayTracer)
        {
            _view = view;
            _rayTracer = rayTracer;
            Initialize();
        }

        private void Initialize()
        {
            _view.cmdColorClick += cmdColorClick;
        }

        private void cmdColorClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
