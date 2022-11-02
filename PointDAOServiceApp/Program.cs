using PointDAOServiceApp.DAO;
using PointDAOServiceApp.DTO;
using PointDAOServiceApp.Model;
using PointDAOServiceApp.Service;

namespace PointDAOServiceApp
{
    internal class Program
    {
        private static IPointDAO dao = new PointDAOImpl();
        private static IPointService service = new PointServiceImpl(dao);

        static void Main(string[] args)
        {
            PointDTO p1 = new() { X = 6 };
            PointDTO p2 = new() { X = 2 };
            PointDTO p3 = new() { X = 15 };
            PointDTO p4 = new() { X = 3 };
            PointDTO p5 = new() { X = 25 };
            PointDTO p6 = new() { X = 60 };

            service.InsertPoint(p1);
            service.InsertPoint(p2);
            service.InsertPoint(p3);
            service.InsertPoint(p4);
            service.InsertPoint(p5);
            service.InsertPoint(p6);

            foreach (Point p in service.GetAllPoints())
            {
                Console.WriteLine(p);
            }

            List<Point> points = service.GetAllPoints();

            points.Sort();
            points.ForEach(p => Console.WriteLine(p));

            points.Reverse();
            points.ForEach(p => Console.WriteLine(p));
        }
    }
}