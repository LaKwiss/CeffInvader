using System.Diagnostics;

namespace CeffInvader
{
    public class Ennemies
    {
        public List<Ennemy> ennemies = new List<Ennemy>();
        public Ennemy enemy = new Ennemy();

        public Ennemies()
        {
            
        }

        public void CreateEnnemies() { 
            for (int i = 0; i < 5; i++) 
            {
                ennemies.Add(enemy);
            }

            Debug.WriteLine(ennemies.Count);
        }

        
    }
}
