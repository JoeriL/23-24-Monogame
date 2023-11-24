using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDev_TopDown.AnimationsCode;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct3D9;
using SharpDX.MediaFoundation;

namespace GameDev_TopDown
{
    public class Character : IGameObject, IMovable
    {
        private Texture2D _texture;
        private Rectangle _deelRectangle;
        private int schuifOp_X = 0;
        animationList _animationList;
        Vector2 versnelling = new Vector2(0.05f, 0.05f);

        private Vector2 Limit(Vector2 v, float max)
        {
            if (v.Length() > max)
            {
                var ratio = max / v.Length();
                v.X *= ratio;
                v.Y *= ratio;
            }
            return v;
        }

        public Vector2 positie = new Vector2(0, 0);
        public Vector2 snelheid = new Vector2(50, 50);
        private IInputReader inputReader;

        private MovementManager movementManager = new MovementManager();
        
        public Vector2 Position { get => this.positie; set => this.positie = value; }
        public Vector2 Speed { get => this.snelheid; set => this.snelheid = value; }
        public IInputReader InputReader { get => this.inputReader; set => this.inputReader = value; }

        //SpriteEffects Effect = SpriteEffects.FlipHorizontally;
        /*
         * dia 65
         * 3. Beweging
         * 
         * 
         */
        public Character(Texture2D texture)
        {

        }
        public Character(Texture2D texture, IInputReader inputReader)
        {
            this._texture = texture;
            this.inputReader = inputReader;

            _animationList = new animationList();

            positie = new Vector2(1, 1);
            snelheid = new Vector2(50, 50);
            versnelling = new Vector2(0.05f, 0.05f);
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            Animation currentAnimation;
            Vector2 input = inputReader.ReadInput();
            // Example: If the character is moving horizontally, use the walk animation; otherwise, use the idle animation
            if (input != Vector2.Zero)
            {
                currentAnimation = _animationList.walkanimationList[GetMovementDirection()];
            }
            else
            {
                currentAnimation = _animationList.idleanimationList[GetIdleDirection()];
            }

            // Draw the current animation
            spriteBatch.Draw(_texture, positie, currentAnimation.CurrentFrame.SourceRectangle, Color.White);


        }
        private Direction GetMovementDirection()
        {
            // Determine the primary direction based on movement vector
            if (Math.Abs(inputReader.ReadInput().X) > Math.Abs(inputReader.ReadInput().Y))
            {
                return (inputReader.ReadInput().X > 0) ? Direction.Right : Direction.Left;
            }
            else
            {
                return (inputReader.ReadInput().Y > 0) ? Direction.Down : Direction.Up;
            }
        }

        private Direction GetIdleDirection()
        {
            // Determine the primary direction based on idle vector
            // You might need additional logic here based on your specific requirements
            // For now, returning the right direction as an example
            return Direction.Right;
        }
        public void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {

            Move(gameTime,graphics);
            Vector2 input = inputReader.ReadInput();

            if (input != Vector2.Zero)
            {
                // If any arrow key is pressed, update movement animation
                UpdateMovementAnimation(input, gameTime);
            }
            else
            {
                // If no arrow keys are pressed, update idle animation
                UpdateIdleAnimation(gameTime);
            }

        }
        private void UpdateIdleAnimation(GameTime gameTime)
        {
            // Update idle animation based on the direction the character is facing
            foreach (KeyValuePair<Direction, IdleAnimation> kvp in _animationList.idleanimationList)
            {
                kvp.Value.Update(gameTime);
            }
        }
        private void UpdateMovementAnimation(Vector2 input, GameTime gameTime)
        {
            // Determine the direction based on input vector
            Direction movementDirection = DetermineMovementDirection(input);

            // Update movement animation based on the direction
            foreach (KeyValuePair<Direction, WalkAnimation> kvp in _animationList.walkanimationList)
            {
                if (kvp.Key == movementDirection)
                {
                    kvp.Value.Update(gameTime);
                }
            }

            // Move the character based on input
            positie += input * snelheid * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Limit the speed to ensure consistent movement speed in all directions
            snelheid = Limit(snelheid, 5.0f);
        }
        private Direction DetermineMovementDirection(Vector2 input)
        {
            // Determine the primary direction based on input vector
            if (Math.Abs(input.X) > Math.Abs(input.Y))
            {
                return (input.X > 0) ? Direction.Right : Direction.Left;
            }
            else
            {
                return (input.Y > 0) ? Direction.Down : Direction.Up;
            }
        }
        private void Move(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            movementManager.Move(this,gameTime,graphics);
            
        }

    }
        internal interface IGameObject
        {
            void Update(GameTime gameTime, GraphicsDeviceManager graphics);
            void Draw(SpriteBatch spriteBatch);
        }
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

}
