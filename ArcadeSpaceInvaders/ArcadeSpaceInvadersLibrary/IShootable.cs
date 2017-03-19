using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeSpaceInvadersLibrary
{
    interface IShootable
    {
        int Health
        {
            get;
            set;
        }
        int Points
        {
            get;
            set;
        }

        void GotShot();
        void Destroy();
    }
}
