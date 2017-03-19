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
        Rectangle BoundingBox
        {
            get;
            set;
        }
        Vector2 Speed
        {
            get;
            set;
        }

        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();

    }
}
