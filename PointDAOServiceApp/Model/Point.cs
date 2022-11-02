using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDAOServiceApp.Model
{
    internal class Point : IEquatable<Point>,
        IComparable<Point>
    {
        public int X { get; set; }

        public int CompareTo(Point? other)
        {
            return X - other!.X;
        }

        /// <summary>
        /// Implements IEquatable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Equals(Point? other)
        {
            if (ReferenceEquals(null, other)) return false; 

            return CompareTo(other) == 0;
        }

        /// <summary>
        /// Overrides Objecti.Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
           if ((obj == null) || (obj.GetType() != GetType()))
            {
                return false;
            }

            return CompareTo((Point ?)obj) == 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        public override string? ToString()
        {
            return "X: " + X;
        }

        public static bool operator >(Point? op1, Point? op2)
        {
            if ((op1 == null) || (op2 == null)) return false;
            return op1.CompareTo(op2) > 0;
        }

        public static bool operator <(Point? op1, Point? op2)
        {
            if ((op1 == null) || (op2 == null)) return false;
            return op1.CompareTo(op2) < 0;
        }

        public static bool operator >=(Point? op1, Point? op2)
        {
            if ((op1 == null) || (op2 == null)) return false;
            return op1.CompareTo(op2) >= 0;
        }

        public static bool operator <=(Point? op1, Point? op2)
        {
            if ((op1 == null) || (op2 == null)) return false;
            return op1.CompareTo(op2) <= 0;
        }

        /*public static bool operator ==(Point? op1, Point? op2)
        {
            if ((op1 == null) || (op2 == null)) return false;
            if (ReferenceEquals(op1, op2)) return true; 
            return op1.CompareTo(op2) == 0;
        }

        public static bool operator !=(Point? op1, Point? op2)
        {
            if ((op1 == null) || (op2 == null)) return false;
            return op1.CompareTo((Point?)op2) != 0;
        }*/
    }
}
