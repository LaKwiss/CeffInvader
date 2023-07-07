using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace CeffInvader
{
    public class EnemySuperVisor
    {
        public List<Enemy> EnemiesList = new List<Enemy>();
        public Enemy enemy = new Enemy();
        int i, y;

        Image img;

        public EnemySuperVisor()
        {
            img = Image.FromFile("Ennemy.png");
        }

        public void CreateEnnemies() { 
            for (int i = 0; i < 5; i++) 
            {
                EnemiesList.Add(enemy);
            }

            // Debug.WriteLine(EnemiesList.Count);
        }
        
        public void Draw(Graphics gr, int i)
        {
            gr.DrawImage(img, i * 50 + 50, y, 50, 50);
        }

        public void Move() 
        {
            y++;
        }
    }
}
