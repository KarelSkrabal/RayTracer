﻿namespace RayTracerLib
{
    public class Light
    {
        Vector light;

        public Light() => light = new Vector(0.0, 0.0, 0.0);

        public Light(double x, double y, double z)
        {
            light = new Vector(x, y, z);
            light.normalize();
        }

        public Light(Light light) => this.light = new Vector(light.light);
    }
}
