using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ArcadeSpaceInvadersLibrary
{
    /// <summary>
    /// defines the base behavior of projectiles such as bullets and torpedos
    /// </summary>
    public abstract class Projectile
    {
        private Vector2 position;
        private int speed;

        public Vector2 Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public abstract void move();
         
    }
}
