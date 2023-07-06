namespace CeffInvader
{
    public class Ennemy
    {
        Image img;
        public int x;
        public int y;
        public int rayon;
        public int dx;
        public int dy;
        public List<Ennemy> EnemyList = new List<Ennemy>();

        public Ennemy(int x, int y, int rayon, int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.rayon = rayon;
            this.dx = dx;
            this.dy = dy;

            img = Image.FromFile("Ennemy.png");
        }
        public void Draw(Graphics gr)
        {
            int PosX = 100;
            int PosY = 100;


            gr.DrawImage(img, PosX, PosY, 50, 50);
        }

        

        public void Move()
        {
            
        }
    }
}
