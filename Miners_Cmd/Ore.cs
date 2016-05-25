using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Miners_Cmd
{
    class Ore
    {
        public string oreType;
        public int x, y, size, speed, health, score;

        public Ore(string _oreType, int _x, int _y, int _size, int _speed, int _health, int _score)
        {
            oreType = _oreType;
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            health = _health;
            score = _score;
        }
        //moves without a move method.

        //collision between ores and bullets
        public bool bulletCollision(Ore o, Bullet b)
        {
            Rectangle oRec = new Rectangle(o.x, o.y, o.size, o.size);
            Rectangle bRec = new Rectangle(b.x, b.y, b.size, b.size);

            if (bRec.IntersectsWith(oRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
