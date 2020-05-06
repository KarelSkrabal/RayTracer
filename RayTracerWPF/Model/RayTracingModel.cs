using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.Model
{
    class RayTracingModel : ObservableObject
    {
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                Set<decimal>(() => this.Salary, ref salary, value);
            }
        }
    }
}
