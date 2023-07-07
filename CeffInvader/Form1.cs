using System.Diagnostics;
using System.Security.Cryptography;

namespace CeffInvader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int vitesse = 5;
        int maxGunRate = 20;
        public int x = 50;
        bool left, right, up, down, shoot = false;
        int xx, yy, clock, tf;
        Image img = Image.FromFile("Ennemy.png");

        SpaceShip MainShip = new SpaceShip(300, 300, 50, 50);
        EnemySuperVisor AllEnemyControl = new EnemySuperVisor();   
        
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
                case Keys.A: left = a; break;
                case Keys.D: right = a; break;
                case Keys.W: up = a; break;
                case Keys.S: down = a; break;
                case Keys.Space: shoot = a; break;
                default: break;
            }
        }
        public void MoveShip()
        {
            if (right) { MainShip.Move(1, 1 * vitesse); }
            if (left) { MainShip.Move(2, 1 * vitesse); }
            if (down) { MainShip.Move(3, 1 * vitesse); }
            if (up) { MainShip.Move(4, 1 * vitesse); }
            if (shoot) { if (clock % maxGunRate == 0) { MainShip.Fire(); } }

            clock++;
        }
        public void PbxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            MainShip.Draw(gr);

            foreach (SpaceShipBullet bullet in MainShip.SpaceShipBulletsList)
            {
                bullet.Draw(gr);
                bullet.Move();
            }

            for (int i = 0; i < 5; i++)
            {
                AllEnemyControl.Draw(gr, i);
            }

            if (tf % 20 == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    AllEnemyControl.Move();
                }

                tf++;
            }

            foreach (Enemy bot in AllEnemyControl.EnemiesList)
            {
                AllEnemyControl.Move();
            }


        }

        private void Tmr_Tick_1(object sender, EventArgs e)
        {
            MoveShip();
            PbxMain.Refresh();

            if (tf == 0)
            {
                AllEnemyControl.CreateEnnemies();
            }
            tf++;

            

        }
    }
}