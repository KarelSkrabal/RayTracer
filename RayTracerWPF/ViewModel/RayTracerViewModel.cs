﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerWPF.Model
{
    //this's like SongViewModel
    //will contain properties of all objects
    public class RayTracerViewModel : ObservableObject
    {
        private SphereObject _sphereObject;
        public SphereObject SphereObject
        {
            get => _sphereObject;
            set => _sphereObject = value;
        }
        public double CenterX
        {
            get => SphereObject.CenterX;
            set
            {
                if(SphereObject.CenterX != value)
                {
                    SphereObject.CenterX = value;
                    RaisePropertyChanged(nameof(CenterX));
                }
            }
        }
        public double CenterY
        {
            get => SphereObject.CenterY;
            set
            {
                if (SphereObject.CenterY != value)
                {
                    SphereObject.CenterY = value;
                    RaisePropertyChanged(nameof(CenterY));
                }
            }
        }
        public double CenterZ
        {
            get => SphereObject.CenterZ;
            set
            {
                if (SphereObject.CenterZ != value)
                {
                    SphereObject.CenterZ = value;
                    RaisePropertyChanged(nameof(CenterZ));
                }
            }
        }
        public double RadiusXXXX
        {
            get => SphereObject.RadiusXX;
            set
            {
                if (SphereObject.RadiusXX != value)
                {
                    SphereObject.RadiusXX = value;
                    RaisePropertyChanged(nameof(RadiusXXXX));
                }
            }
        }
        public string Color
        {
            get => SphereObject.Color;
            set
            {
                if (SphereObject.Color != value)
                {
                    SphereObject.Color = value;
                    RaisePropertyChanged(nameof(RadiusXXXX));
                }
            }
        }
        public RayTracerViewModel()
        {
            SphereObject = new SphereObject { RadiusXX = -50.0, CenterX = -200.0, CenterY = -300.0, CenterZ = 0.0, Color = "xxx" };
        }
    }
}
