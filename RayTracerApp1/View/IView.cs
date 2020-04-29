using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerApp1.View
{
    public class IView
    {
        event EventHandler<EventArgs> Clear;
    }
}
