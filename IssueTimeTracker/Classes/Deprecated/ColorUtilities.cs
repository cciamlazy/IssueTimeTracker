
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTimeTracker.Classes.Helper
{
    public static class ColorUtilities
    {
        /*public static HSL RGB2HSL(Color c)
        {
            HSL hsl = new HSL();
            // Convert RGB to a 0.0 to 1.0 range.
            double double_r = c.R / 255.0;
            double double_g = c.G / 255.0;
            double double_b = c.B / 255.0;

            // Get the maximum and minimum RGB components.
            double max = double_r;
            if (max < double_g) max = double_g;
            if (max < double_b) max = double_b;

            double min = double_r;
            if (min > double_g) min = double_g;
            if (min > double_b) min = double_b;

            double diff = max - min;
            hsl.L = (max + min) / 2;
            if (Math.Abs(diff) < 0.00001)
            {
                hsl.S = 0;
                hsl.H = 0;  // H is really undefined.
            }
            else
            {
                if (hsl.L <= 0.5) hsl.L = diff / (max + min);
                else hsl.S = diff / (2 - max - min);

                double r_dist = (max - double_r) / diff;
                double g_dist = (max - double_g) / diff;
                double b_dist = (max - double_b) / diff;

                if (double_r == max) hsl.H = b_dist - g_dist;
                else if (double_g == max) hsl.H = 2 + r_dist - b_dist;
                else hsl.H = 4 + g_dist - r_dist;

                hsl.H = hsl.H * 60;
                if (hsl.H < 0) hsl.H += 360;
            }

            return hsl;
        }

        public static Color HSL2RGB(HSL hsl)
        {
            double r = 0, g = 0, b = 0;
            if (hsl.L != 0)
            {
                if (hsl.S == 0)
                    r = g = b = hsl.L;
                else
                {
                    double temp2;
                    if (hsl.L < 0.5)
                        temp2 = hsl.L * (1.0 + hsl.S);
                    else
                        temp2 = hsl.L + hsl.S - (hsl.L * hsl.S);

                    double temp1 = 2.0 * hsl.L - temp2;

                    r = GetColorComponent(temp1, temp2, hsl.H + 1.0 / 3.0);
                    g = GetColorComponent(temp1, temp2, hsl.H);
                    b = GetColorComponent(temp1, temp2, hsl.H - 1.0 / 3.0);
                }
            }
            return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
        }

        private static double GetColorComponent(double temp1, double temp2, double temp3)
        {
            if (temp3 < 0.0)
                temp3 += 1.0;
            else if (temp3 > 1.0)
                temp3 -= 1.0;

            if (temp3 < 1.0 / 6.0)
                return temp1 + (temp2 - temp1) * 6.0 * temp3;
            else if (temp3 < 0.5)
                return temp2;
            else if (temp3 < 2.0 / 3.0)
                return temp1 + ((temp2 - temp1) * ((2.0 / 3.0) - temp3) * 6.0);
            else
                return temp1;
        }

        public static CMYK RGB2CMYK(Color rgb)
        {
            double dr = (double)rgb.R / 255;
            double dg = (double)rgb.G / 255;
            double db = (double)rgb.B / 255;
            double k = 1 - Math.Max(Math.Max(dr, dg), db);
            double c = (1 - dr - k) / (1 - k);
            double m = (1 - dg - k) / (1 - k);
            double y = (1 - db - k) / (1 - k);

            return new CMYK() { C = c, M = m, Y = y, K = k };
        }

        public static String HexConverter(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public static String RGBConverter(Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }*/
    }
}
