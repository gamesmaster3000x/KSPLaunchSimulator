using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data
{
    internal class Vector264
    {
        public double x;
        public double y;

        public Vector264(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector264(Vector264 other)
        {
            x = other.x;
            y = other.y;
        }

        public static readonly Vector264 Zero = new(0, 0);
        public static readonly Vector264 One = new(1, 1);

        public static Vector264 operator +(Vector264 a) => new(a);
        public static Vector264 operator -(Vector264 a) => new(-a.x, -a.y);
        public static Vector264 operator +(Vector264 a, Vector264 b) => new(a.x + b.x, a.y + b.y);
        public static Vector264 operator -(Vector264 a, Vector264 b) => new(a.x - b.x, a.y - b.y);
        public static Vector264 operator *(Vector264 a, double b) => new(a.x * b, a.y * b);
        public static Vector264 operator /(Vector264 a, double b) => new(a.x / b, a.y / b);

        public override string ToString()
        {
            return "X: " + x.ToString("n3") + ", Y: " + y.ToString("n3");
        }
    }
}
