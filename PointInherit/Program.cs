namespace PointInherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable p1 = new Point();
            IMoveable p2 = Point.GetPoint();
            Point p3 = new();
            Point p4 = new()
            {
                X = 5
            };

            Point p5 = new Point2D();
            Point p6 = new Point3D();

            p4.Move5();
            p6.Move5();

            DoMove5(p1);
            DoMove5(p6);
        }

        public static void DoMove5(IMoveable point)
        {
            point.Move5();
        }
    }
}