﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameDev_TopDown.AnimationsCode
{
    class ShootAnimation : Animation
    {
        public ShootAnimation()
        {

        }
        public ShootAnimation(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    for (int i = 48 * 3; i < 48 * 6 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1632, 48, 96)));
                    }
                    break;
                case Direction.Down:
                    for (int i = 48 * 9; i < 48 * 12 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1632, 48, 96)));
                    }
                    break;
                case Direction.Left:
                    for (int i = 48 * 6; i < 48 * 9 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1632, 48, 96)));
                    }
                    break;
                case Direction.Right:
                    for (int i = 0; i < 48 * 3 - 1; i += 48)
                    {
                        AddFrame(new AnimationFrame(new Rectangle(i, 1632, 48, 96)));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}