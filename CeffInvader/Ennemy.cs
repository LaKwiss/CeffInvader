namespace CeffInvader
{
    public class Ennemy
    {
        Image img;



        public Ennemy()
        {
            img = Image.FromFile("Ennemy.png");

        }

        public void Draw(int x, Graphics gr, int limit)
        {
            for (int y = 0; y < limit; y++)
            {
                gr.DrawImage(img, x, 50, 50, 50);
                x += 50;
            }
        }



    }
}
