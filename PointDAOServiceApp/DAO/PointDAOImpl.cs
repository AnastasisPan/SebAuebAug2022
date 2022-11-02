using PointDAOServiceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDAOServiceApp.DAO
{
    internal class PointDAOImpl : IPointDAO
    {
        private static List<Point> points = new();
        public static List<Point> Points { get { return new(points);  } }

        public void Insert(Point? p)
        {
            if (p == null) return;
            points.Add(p);
        }

        public Point? Delete(Point p)
        {
            if(p == null) return null;
            if (!points.Remove(p))
            {
                return null;
            }

            return p;
        }

        public List<Point> GetAllPoints()
        {
            return Points;
        }

        public Point? GetPoint(Point p)
        {
            if (p == null) return null;

            return points.Contains(p) ? points[points.IndexOf(p)] : null;
            /*if (points.Contains(p))
            {
                return points[points.IndexOf(p)];
            }
            else
            {
                return null;
            }*/
        }

        public bool Update(Point? p, int x)
        {
            if (p == null) return false;

            int positionToUpdate = points.IndexOf(p);

            if (positionToUpdate < 0) return false;

            points[positionToUpdate].X = x;
            return true;
        }
    }
}
