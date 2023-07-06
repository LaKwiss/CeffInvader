using System.Diagnostics;

namespace CeffInvader
{
    public class Ennemies
    {
        public List<Ennemy> ennemies = new List<Ennemy>();
        public Ennemy enemy = new Ennemy();

        Image img;

        public Ennemies()
        {
            img = Image.FromFile("Ennemy.png");
        }

        public void CreateEnnemies() { 
            for (int i = 0; i < 5; i++) 
            {
                ennemies.Add(enemy);
            }

            Debug.WriteLine(ennemies.Count);
        }

        public void Draw(int x, Graphics gr, int limit)
        {
            for (int y = 0; y < limit; y++)
            {
                gr.DrawImage(img, x, 50, 50, 50);
                x += 50;
            }
        }

        public void MoveAllEnemies(List<Ennemy> ennemies) 
        {
            
        }
    }
}
