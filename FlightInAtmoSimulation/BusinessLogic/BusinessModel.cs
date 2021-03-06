using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BusinessModel
    {
        const double dt = 0.01;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        double a;
        double v0;
        double y0;
        double s;
        double m;
        double k;

        double t;
        double vx;
        double vy;

        public double X { get; set; }
        public double Y { get; set; }

        public void StartFlight(double a, double v0, double y0, double m, double s)
        {
            this.a = a;
            this.v0 = v0;
            this.y0 = y0;
            this.m = m;
            this.s = s;

            k = 0.5 * C * s * rho / m;

            vx = v0 * Math.Cos(a * Math.PI / 180);
            vy = v0 * Math.Sin(a * Math.PI / 180);

            t = 0;
            X = 0;
            Y = y0;
        }

        public void GenerateNextPoint()
        {
            t += dt;
            vx = vx - k * vx * Math.Sqrt(vx * vx + vy * vy) * dt;
            vy = vy - (g + k * vy * Math.Sqrt(vx * vx + vy * vy)) * dt;
            X = X + vx * dt;
            Y = Y + vy * dt;
        }
    }
}
