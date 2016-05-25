using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miners_Cmd
{
    class Bullet
    {
        public int x, y, size, speed, damage;

        public Bullet(int _x, int _y, int _size, int _speed, int _damage)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            damage = _damage;
        }

        //moves without a move method.
    }
}
