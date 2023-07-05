using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace CeffInvader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int vitesse = 5;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        bool shoot = false;

        SpaceShip MainShip = new SpaceShip(300, 300, 50, 50, 5);

        


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TestKey(true, e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            TestKey(false, e.KeyCode);
        }

        public void TestKey(bool a, Keys k)
        {
            switch (k)
            {
                case Keys.A:
                    left = a;

                    break;
                case Keys.D:
                    right = a;

                    break;
                case Keys.W:
                    up = a;

                    break;
                case Keys.S:
                    down = a;

                    break;
                case Keys.Space:
                    shoot = a;
                    break;
                default:
                    break;


            }
        }
        public void Move()
        {
            if (right)  { MainShip.move(1, 1 * vitesse); }
            if (left)   { MainShip.move(2, 1 * vitesse); }
            if (down)   { MainShip.move(3, 1 * vitesse); }
            if (up)     { MainShip.move(4, 1 * vitesse); }
            if (shoot)  { MainShip.fire(); }
        }

        public void tmr_Tick(object sender, EventArgs e)
        {
            Move();
            PbxMain.Refresh();
        }

        public void PbxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            MainShip.Draw(gr);
            
            foreach (SpaceShipBullet bullet in MainShip.SpaceShipBullets)
            {
                bullet.draw(gr);
                bullet.move();
            }
        }
    }
}