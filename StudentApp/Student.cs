using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        private int id;
        private string? firstname;
        private string? lastname;

        public Student() { }
        
        public int Id { get => id;  private set => id = value; }
        public string Firstname { get { return firstname!; } set { firstname = value; } }
        public string Lastname { get { return lastname!; } set { lastname = value; } }
    }
}
