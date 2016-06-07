using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miners_Cmd
{
    class Bullet
    {
        public int x, y, size, speed;

        public Bullet(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }

        //moves without a move method.
    }
}
