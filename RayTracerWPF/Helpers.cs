using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF
{
    public static class Helpers
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> col) => new ObservableCollection<T>(col);
    }
}
