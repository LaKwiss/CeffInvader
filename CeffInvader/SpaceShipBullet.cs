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
        Image img;

        public SpaceShipBullet(int x, int y)
        {
            this.x = x; 
            this.y = y;

            img = Image.FromFile("Bullet.png");
        }

        public void Draw(Graphics gr)
        {
            gr.DrawImage(img, y + 19, x, 12, 21);
        }

        public void Move()
        {
            x -= 2;
        }
    }
}
