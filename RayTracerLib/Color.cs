namespace RayTracerLib
{
    public class Color
    {
        double r;
        public double R
        {
            get => r;
            set
            {
                int rvalue = (int)(value);
                rvalue = rvalue > 255 ? 255 : rvalue;
                r = rvalue < 0 ? 0 : rvalue;
            }
        }
        double g;
        public double G
        {
            get => g;
            set
            {
                int gvalue = (int)(value);
                gvalue = gvalue > 255 ? 255 : gvalue;
                g = gvalue < 0 ? 0 : gvalue;
            }
        }
        double b;
        public double B
        {
            get => b;
            set
            {
                int bvalue = (int)(value);
                bvalue = bvalue > 255 ? 255 : bvalue;
                b = bvalue < 0 ? 0 : bvalue;
            }
        }
        public Color()
        {
            R = 0.0;
            G = 0.0;
            B = 0.0;
        }
        public Color(double r, double g, double b)
        {
            R = r;
            G = g;
            B = b;
        }

        public Color(Color color)
        {
            R = color.r;
            G = color.g;
            B = color.b;
        }
        public static Color GetShedowedColor(bool bShadow, Color color, double cost)
        {
            if (cost < 0)
                cost = 0;
            double fact = (bShadow == true) ? 0.5 : 1.0;
            return new Color(
                color.R * cost * fact,
                color.G * cost * fact,
                color.B * cost * fact);
        }

        public override string ToString() => "RGB(R = " + R + " , G = " + G + " , B = " + B + ")";
    }
}
