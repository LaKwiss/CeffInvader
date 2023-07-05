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

        public SpaceShipBullet(int x, int y)
        {
            this.x = x; 
            this.y = y;

            

            brush = new SolidBrush(Color.FromArgb(252, 136, 3));
        }

        public void draw(Graphics gr)
        {
            gr.FillEllipse(brush, y, x, 30, 30);
        }

        public void move()
        {
            x -= 5;
        }
    }
}
