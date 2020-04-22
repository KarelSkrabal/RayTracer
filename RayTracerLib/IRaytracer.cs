﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Light direction
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
        /// <summary>
        /// 
        /// </summary>
        Color[,] RayTrace();
    }
}
