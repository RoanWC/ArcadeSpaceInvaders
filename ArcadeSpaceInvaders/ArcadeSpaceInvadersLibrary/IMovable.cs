using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeSpaceInvadersLibrary
{
    interface IMovable
    {
        Vector2 Position
        {
            get;
            set;
        }
        int Speed
        {
            get;
            set;
        }

        void move();

    }
}
