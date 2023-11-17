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
        public void Move(IMovable movable)
        {
            var direction = movable.InputReader.ReadInput();
            if (movable.InputReader.IsDestinationInput)
            {
                direction -= movable.Position;
                direction.Normalize();
            }

            var afstand = direction * movable.Speed;
            var toekomstigePositie = movable.Position + direction;
            if (
              (toekomstigePositie.X < (800 - 160)
               && toekomstigePositie.X > 0) &&
               (toekomstigePositie.Y < 480 - 96
               && toekomstigePositie.Y > 0)
            )
            {
                movable.Position = toekomstigePositie;
            }

        }

    }
    public interface IMovable
    {
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public IInputReader InputReader { get; set; }
    }


}
