namespace CeffInvader
{
    public class Ennemies
    {
        public List<Ennemy> EnnemiesList = new List<Ennemy>();

        /// <summary>
        /// Crée la classe
        /// </summary>
       
        public Ennemies()
        {
            
        }

        /// <summary>
        /// Dessine les ennemies
        /// </summary>
        /// <param name="gr">contexte graphique</param>
        
        public void Draw(Graphics gr)
        {
            foreach (Ennemy ennemy in EnnemiesList)
            {
                ennemy.Draw(gr);
            }   
        }

        public void Move()
        {
            foreach (Ennemy ennemy in EnnemiesList)
            {
                int Direction = 1;
                int Vitesse = 1;


                ennemy.Move(Direction, Vitesse);
            }
        }
    }
}
