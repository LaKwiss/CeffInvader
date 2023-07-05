using System.Drawing;

namespace CeffInvader
{
    public class SpaceShip
    {
        public int x;
        public int y;
        public int PosiX;
        public int PosiY;
        public int vitesse;
        Image img;

        public List<SpaceShipBullet> SpaceShipBullets = new List<SpaceShipBullet>();

        public SpaceShip(int PosiX, int PosiY, int x, int y, int vitesse)
        {
            this.x = x;
            this.y = y;
            this.vitesse = vitesse;
            this.PosiX = PosiX;
            this.PosiY = PosiY;

            img = Image.FromFile("MainShip.jpg");

        }

        public void Draw(Graphics gr)
        {
            gr.DrawImage(img, PosiX, PosiY, x, y);
        }

        public void move(int Direction, int v)
        {
            switch (Direction)
            {
                case 1: PosiX += v * 2; break;
                case 2: PosiX -= v * 2; break;
                case 3: PosiY += v * 2; break;
                case 4: PosiY -= v * 2; break;
            }
        }

        public void fire()
        {
            SpaceShipBullet bullet = new SpaceShipBullet(PosiY, PosiX);
            SpaceShipBullets.Add(bullet);
        }
    } 
}
