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
        public List<Ennemy> EnnemyBullets = new List<Ennemy>();

        public Ennemy(int x, int y, int rayon, int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.rayon = rayon;
            this.dx = dx;
            this.dy = dy;

            img = Image.FromFile("Ennemy.png");
        }
        public void Setup()
        {
            Ennemy ennemy = new Ennemy();
            EnnemyBullets.Add(ennemy);
        }

        public void Draw(Graphics gr)
        {
            gr.DrawImage(img, x, 0, 50, 50);
        }

        public void Move()
        {
            
        }
    }
}
