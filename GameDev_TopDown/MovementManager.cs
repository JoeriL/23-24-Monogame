using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameDev_TopDown
{
    class MovementManager 
    {
        public void Move(IMovable movable, GameTime gameTime, GraphicsDeviceManager graphics)
        {
            var direction = movable.InputReader.ReadInput();
            
            var afstand = direction * movable.Speed;
            var toekomstigePositie = movable.Position + afstand;

            if (IsWithinScreenBoundaries(toekomstigePositie, graphics))
            {
                movable.Position = toekomstigePositie;
            }

        }
        private bool IsWithinScreenBoundaries(Vector2 position, GraphicsDeviceManager graphics)
        {
            int screenWidth = graphics.PreferredBackBufferWidth - 48;
            int screenHeight = graphics.PreferredBackBufferHeight - 96;

            return (position.X >= 0 && position.X <= screenWidth &&
                    position.Y >= 0 && position.Y <= screenHeight);
        }

    }
    public interface IMovable
    {
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public IInputReader InputReader { get; set; }
    }


}
