using PointDAOServiceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDAOServiceApp.DAO
{
    internal interface IPointDAO
    {
        void Insert(Point p);
        bool Update(Point p, int x);
        Point? Delete(Point p);
        Point? GetPoint(Point p);
        List<Point> GetAllPoints();
    }
}
