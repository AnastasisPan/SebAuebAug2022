using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PointInherit
{
    internal class Point : IMoveable
    {
        public int X { get; set; }

        //Static Factory
        public static Point GetPoint()
        {
            return new Point();
        }

        public virtual void Move5()
        {
            X += 5;
        }

        public override string ToString()
        {
            return $"({X})";
        }
    }
}
