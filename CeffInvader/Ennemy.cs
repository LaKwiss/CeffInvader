using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeffInvader
{
    public class Ennemy
    {
        Image img;

        public Ennemy()
        {
            img = Image.FromFile("Ennemy.png");
        }

        public void Move(int Directon, int Vitesse)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Déplace un ennemi (à utiliser dans un ennemies.move)
        /// </summary>
        /// <param name="gr"></param>

        public void Draw(Graphics gr)
        {
            gr.DrawImage(img, x, y, 50, 50);
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

    }
}
