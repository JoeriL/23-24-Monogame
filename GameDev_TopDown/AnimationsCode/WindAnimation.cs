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
    class WindAnimation : Animation
    {
        public WindAnimation()
        {

        }
        public WindAnimation(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    for (int i = 48 * 30 + 8; i < 48 * 36 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1440, 48, 96)));
                    }
                    break;
                case Direction.Down:
                    for (int i = 48 * 42 + 8; i < 48 * 48 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1440, 48, 96)));
                    }
                    break;
                case Direction.Left:
                    for (int i = 48 * 36 + 8; i < 48 * 42 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1440, 48, 96)));
                    }
                    break;
                case Direction.Right:
                    for (int i = 48 * 24 + 8; i < 48 * 30 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1440, 48, 96)));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}