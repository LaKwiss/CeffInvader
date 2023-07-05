namespace CeffInvader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int vitesse = 5;
        bool left, right, up, down, shoot = false;

        SpaceShip MainShip = new SpaceShip(300, 300, 50, 50);
        Ennemy Ennemy = new Ennemy();

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
            if (shoot) { MainShip.Fire(); }

        }

        public void PbxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            MainShip.Draw(gr);
            
            Ennemy.Draw(gr);

            foreach (SpaceShipBullet bullet in MainShip.SpaceShipBullets)
            {
                bullet.Draw(gr);
                bullet.Move();

            }

            
        }

        private void Tmr_Tick_1(object sender, EventArgs e)
        {
            MoveShip();
            PbxMain.Refresh();
        }

        
    }
}