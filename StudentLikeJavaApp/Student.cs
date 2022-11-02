using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLikeJavaApp
{
    internal class Student
    {
        private int id;
        private string? firstname;
        private string? lastname;

        public Student() { }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
}
