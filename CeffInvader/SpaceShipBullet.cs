using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeffInvader
{
    public class SpaceShipBullet
    {
        public int x;
        public int y;
        public SolidBrush brush;
        public int speed;
        public uint param;
        private SpaceShip owner;

        public SpaceShipBullet(int x, int y, int speed, uint param, SpaceShip owner)
        {
            this.x = x; 
            this.y = y;
            this.speed = speed;
            this.param = param;

            int r = 252;
            int g = 136;
            int b = 3;

            this.owner = owner;

            brush = new SolidBrush(Color.FromArgb(r, g, b));
        }

        public void draw(Graphics gr)
        {
            gr.FillEllipse(brush, y, x, 30, 30);
        }

        public void move()
        {
            x -= speed;
        }
    }
}
