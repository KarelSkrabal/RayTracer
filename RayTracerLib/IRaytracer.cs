using System.Collections;
using System.Collections.Generic;

namespace RayTracerLib
{
    public interface IRaTracer
    {
        /// <summary>
        /// Eye position (camera)
        /// </summary>
        RayTracerLib.Vector p { get; set; }
        /// <summary>
        /// Light position
        /// </summary>
        RayTracerLib.Vector lp { get; set; }
        /// <summary>
        /// Light direction (vector)
        /// </summary>
        RayTracerLib.Vector lv { get; set; }
        //light color
        /// <summary>
        /// Width of the canvas
        /// </summary>
        int canvasWidth { get; set; }
        /// <summary>
        /// Height of canvas
        /// </summary>
        int canvasHeight { get; set; }
        List<BaseObject> objects { get; set; }
        /// <summary>
        /// Ray tracing, outputs array of colors for all pixels on canvas
        /// </summary>
        void RayTrace(ref Color[,] pixels);
    }
}
