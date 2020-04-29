using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerApp1
{
    public static class Helpers
    {
        public static string SetDoubleFormat(this string value) => value.Replace('.', ',');
    }
}
