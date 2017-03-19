using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ArcadeSpaceInvadersLibrary
{
    class HeroShip : IMovable , IShootable, IShooter
    {
        //private fields
        
        private Vector2 speed;
        private int health;
        private int points;
        private Rectangle boundingBox;
        private int screeenWidth;
        private int screenHeight;


        //properties
        public Vector2 Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }
        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }
        public Rectangle BoundingBox
        {
            get
            {
                return boundingBox;
            }
            set
            {
                boundingBox = value;
            }
        }
        public int ScreenWidth
        {
            get
            {
                return screeenWidth;
            }
            set
            {
                screeenWidth = value;
            }
        }


        //methods

        public HeroShip(int shipWidth, int shipHeight, int screenWidth, int screenHeight, Vector2 speed)
        {
            Speed = speed;
            Health = 3;
            Points = 0;
            BoundingBox = new Rectangle(screeenWidth / 2 + shipWidth / 2, screenHeight - shipHeight, shipWidth, shipHeight);
            ScreenWidth = screenWidth;
        }

        public void MoveLeft()
        {
            boundingBox.X = (int)MathHelper.Clamp(boundingBox.X - speed.X, 0, screeenWidth - boundingBox.Width);
        }
        public void MoveRight()
        {
            boundingBox.X = (int)MathHelper.Clamp(boundingBox.X + speed.X, 0, screeenWidth - boundingBox.Width);
        }

        public void GotShot()
        {
            health -= 1;
            if (health == 0){
                Destroy();
            }
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {
            throw new NotSupportedException();
        }

        public void MoveDown()
        {
            throw new NotSupportedException();
        }

        
    }
}
