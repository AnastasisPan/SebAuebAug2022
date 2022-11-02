using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInherit
{
    internal class MovingSpace
    {
        private IMoveable moveable;

        public MovingSpace(IMoveable moveable)
        {
            this.moveable = moveable;
        }

        public void DoMove5()
        {
            moveable.Move5();
        }
    }
}
