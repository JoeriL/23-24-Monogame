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
        public Vector2 snelheid = new Vector2(1, 1);
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
            snelheid = new Vector2(2, 2);
            versnelling = new Vector2(0.1f, 0.1f);
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, positie, _animationList.attackanimationList[Direction.Right].CurrentFrame.SourceRectangle, Color.White/*, Effect*/);
            spriteBatch.Draw(_texture, positie, _animationList.windanimationList[Direction.Right].CurrentFrame.SourceRectangle, Color.White/*, Effect*/);

        }
        public void Update(GameTime gameTime)
        {

            Move();
            foreach (KeyValuePair<Direction, AttackAnimation> kvp in _animationList.attackanimationList)
            {
                kvp.Value.Update(gameTime);
            }
            foreach (KeyValuePair<Direction, WindAnimation> kvp in _animationList.windanimationList)
            {
                kvp.Value.Update(gameTime);
            }
        }
        private void Move()
        {
            movementManager.Move(this);
            
        }

    }
        internal interface IGameObject
        {
            void Update(GameTime gameTime);
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
