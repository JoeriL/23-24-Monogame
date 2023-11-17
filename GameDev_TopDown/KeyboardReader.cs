using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static GameDev_TopDown.MouseReader;

namespace GameDev_TopDown
{
    class KeyboardReader : IInputReader
    {
        public bool IsDestinationInput => false;

        public Vector2 ReadInput()
        {

            KeyboardState state = Keyboard.GetState();
            Vector2 direction = Vector2.Zero;
            if (state.IsKeyDown(Keys.Left))
            {
                direction.X -= 1;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                direction.X += 1;
            }
            return direction;
        }

    }
    class MouseReader : IInputReader
    {
        public bool IsDestinationInput => true;

        public Vector2 ReadInput()
        {
            MouseState state = Mouse.GetState();
            Vector2 directionMouse = new Vector2(state.X, state.Y);
            //if (directionMouse != Vector2.Zero)
            //{
            //    directionMouse.Normalize();
            //}
            return directionMouse;
        }
    }

    public interface IInputReader
    {
        Vector2 ReadInput();
        public bool IsDestinationInput { get; }
    }

}
