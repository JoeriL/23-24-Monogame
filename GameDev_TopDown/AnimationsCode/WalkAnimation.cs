using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameDev_TopDown.AnimationsCode
{
    class WalkAnimation : Animation
    {
        public WalkAnimation()
        {

        }
        public WalkAnimation(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    for (int i = 48 * 6; i < 48 * 12 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 193, 48, 95)));
                    }
                    break;
                case Direction.Down:
                    for (int i = 48 * 18 + 1; i < 48 * 24 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 193, 48, 95)));
                    }
                    break;
                case Direction.Left:
                    for (int i = 48 * 12; i < 48 * 16 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 193, 48, 95)));
                    }
                    break;
                case Direction.Right:
                    for (int i = 48 * 0; i < 48 * 6 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 193, 48, 95)));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

