using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RayTracerWPF
{
    public static class Helpers
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> col) => new ObservableCollection<T>(col);
    }
}
