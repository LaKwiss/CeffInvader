﻿using System.Diagnostics;
using System.Drawing;

namespace CeffInvader
{
    public class SpaceShip
    {
        public int x;
        public int y;
        public int PosiX;
        public int PosiY;
        Image img;

        public List<SpaceShipBullet> SpaceShipBulletsList = new List<SpaceShipBullet>();

        public SpaceShip(int PosiX, int PosiY, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.PosiX = PosiX;
            this.PosiY = PosiY;

            img = Image.FromFile("MainShip.jpg");
        }

        public void Draw(Graphics gr)
        {
            gr.DrawImage(img, PosiX, PosiY, x, y);
            
        }

        public void Move(int Direction, int v)
        {
            switch (Direction)
            {
                case 1: PosiX += v * 2; break;
                case 2: PosiX -= v * 2; break;
                case 3: PosiY += v * 2; break;
                case 4: PosiY -= v * 2; break;
            }
        }

        public void Fire()
        {
            SpaceShipBullet bullet = new SpaceShipBullet(PosiY, PosiX);
            SpaceShipBulletsList.Add(bullet);

            if (SpaceShipBulletsList.Count >= 150)
            {
                SpaceShipBulletsList.RemoveRange(0, 50);
            }

            //Debug.WriteLine(SpaceShipBulletsList.Count);
        }
    } 
}
