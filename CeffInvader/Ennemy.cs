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

        public void Draw(Graphics gr)
        {
            gr.DrawImage(img, 0, 0, 50, 50);
        }

        public void Move()
        {
            
        }
    }
}
