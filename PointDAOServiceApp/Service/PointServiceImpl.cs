using PointDAOServiceApp.DAO;
using PointDAOServiceApp.DTO;
using PointDAOServiceApp.Model;

namespace PointDAOServiceApp.Service
{
    internal class PointServiceImpl : IPointService
    {
        private readonly IPointDAO dao;

        public PointServiceImpl(IPointDAO dao)
        {
            this.dao = dao;
        }

        public void InsertPoint(PointDTO? p)
        {
            if (p == null) return;
            dao.Insert(ExtractDTO(p)!);
        }

        public Point? DeletePoint(PointDTO? p)
        {
            if (p == null) return null;
            return dao.Delete(ExtractDTO(p)!);
        }

        public bool UpdatePoint(PointDTO? p, int x)
        {
            if (p == null) return false;
            return dao.Update(ExtractDTO(p)!, x);
        }



        public List<Point> GetAllPoints()
        {
            return dao.GetAllPoints();
        }

        public Point? GetPointFromDB(PointDTO? p)
        {
            if (p == null) return null;
            return dao.GetPoint(ExtractDTO(p)!);
        }

        private Point? ExtractDTO(PointDTO? dto)
        {
            if (dto == null) return null;
            return new Point()
            {
                X = dto.X
            };
        }
    }
}
