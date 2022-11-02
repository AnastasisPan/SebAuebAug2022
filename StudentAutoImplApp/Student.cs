using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAutoImplApp
{
    /// <summary>
    /// POCO - Plain Old CLR Object
    /// </summary>
    internal class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public Student() { }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || (GetType() != obj.GetType())) {
                return false;
            }

            var student = (Student)obj;

            return  (Id == student.Id) &&
                   (Firstname!.Equals(student.Firstname)) &&
                   (Lastname == student.Lastname);
        }

        public override int GetHashCode()
        {
            //return HashCode.Combine(Id, Firstname, Lastname);
            int hash = 13;
            hash = hash * 23 + Id;
            hash = hash * 23 + Firstname?.GetHashCode() ?? 0;
            hash = hash * 23 + Lastname?.GetHashCode() ?? 0;
            return hash;
        }

        public override string? ToString()
        {

            return $"{Id}, {Firstname}, {Lastname} ";
        }
    }
}