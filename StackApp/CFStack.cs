using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class CFStack
    {
        public int[]? Stack { get; set; }
        public int Top { get; set; }
        public int Size { get; set; }

        // Static Factory
        public static CFStack GetStack(int n)
        {
            return new CFStack()
            {
                Stack = new int[n],
                Top = 0,
                Size = n
            };
        }

        public void Push(int num)
        {
            if (Top == Size)
            {
                throw new Exception();
            }
            else
            {
                Stack![Top++] = num;
            }
        }

        public int Pop()
        {
            if (Top ==0)
            {
                throw new Exception();
            }
            else
            {
                Top--;
                return Stack![Top];
            }
        }

    }
}
