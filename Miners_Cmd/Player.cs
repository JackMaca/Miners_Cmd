using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Miners_Cmd
{
    class Player
    {
        public int x, y, size, speed, direction;
        public Image[] player = new Image[2];
        public Player(int _x, int _y, int _size, int _speed, int _direction, Array _player)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            direction = _direction;
            _player = player;
        }

        public void move(Player p, int direction)
        {
            if (direction == 0)
            {
                //left
                p.x -= p.speed;
            }
            else if (direction == 1)
            {
                //right
                p.x += p.speed;
            }
        }
    }
}
