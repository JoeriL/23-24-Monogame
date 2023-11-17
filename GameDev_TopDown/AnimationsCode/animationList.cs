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
    class animationList
    {
        //public IdleAnimation idleanimation;

        public Dictionary<Direction, IdleAnimation> idleanimationList = new Dictionary<Direction, IdleAnimation>();
        public Dictionary<Direction, WalkAnimation> walkanimationList = new Dictionary<Direction, WalkAnimation>();
        public Dictionary<Direction, AttackAnimation> attackanimationList = new Dictionary<Direction, AttackAnimation>();
        public Dictionary<Direction, DamageAnimation> damageanimationList = new Dictionary<Direction, DamageAnimation>();
        public Dictionary<Direction, WindAnimation> windanimationList = new Dictionary<Direction, WindAnimation>();
        //public Dictionary<Direction, DeathAnimation> deathanimationList = new Dictionary<Direction, DeathAnimation>();



        public animationList()
        {
            idleanimationList.Add(Direction.Up, new IdleAnimation(Direction.Up));
            idleanimationList.Add(Direction.Down, new IdleAnimation(Direction.Down));
            idleanimationList.Add(Direction.Left, new IdleAnimation(Direction.Left));
            idleanimationList.Add(Direction.Right, new IdleAnimation(Direction.Right));

            walkanimationList.Add(Direction.Up, new WalkAnimation(Direction.Up));
            walkanimationList.Add(Direction.Down, new WalkAnimation(Direction.Down));
            walkanimationList.Add(Direction.Left, new WalkAnimation(Direction.Left));
            walkanimationList.Add(Direction.Right, new WalkAnimation(Direction.Right));

            attackanimationList.Add(Direction.Up, new AttackAnimation(Direction.Up));
            attackanimationList.Add(Direction.Down, new AttackAnimation(Direction.Down));
            attackanimationList.Add(Direction.Left, new AttackAnimation(Direction.Left));
            attackanimationList.Add(Direction.Right, new AttackAnimation(Direction.Right));

            damageanimationList.Add(Direction.Up, new DamageAnimation(Direction.Up));
            damageanimationList.Add(Direction.Down, new DamageAnimation(Direction.Down));
            damageanimationList.Add(Direction.Left, new DamageAnimation(Direction.Left));
            damageanimationList.Add(Direction.Right, new DamageAnimation(Direction.Right));

            windanimationList.Add(Direction.Up, new WindAnimation(Direction.Up));
            windanimationList.Add(Direction.Down, new WindAnimation(Direction.Down));
            windanimationList.Add(Direction.Left, new WindAnimation(Direction.Left));
            windanimationList.Add(Direction.Right, new WindAnimation(Direction.Right));

            /*

            attackanimation = new Animation();
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(0, 192, 160, 96)));
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(160, 192, 160, 96)));
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(320, 192, 160, 96)));
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(480, 192, 160, 96)));
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(640, 192, 160, 96)));
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(800, 192, 160, 96)));
            attackanimation.AddFrame(new AnimationFrame(new Rectangle(960, 192, 160, 96)));

            damageanimation = new Animation();
            damageanimation.AddFrame(new AnimationFrame(new Rectangle(0, 288, 160, 96)));
            damageanimation.AddFrame(new AnimationFrame(new Rectangle(160, 288, 160, 96)));
            damageanimation.AddFrame(new AnimationFrame(new Rectangle(320, 288, 160, 96)));
            damageanimation.AddFrame(new AnimationFrame(new Rectangle(480, 288, 160, 96)));

            deathanimation = new Animation();
            deathanimation.AddFrame(new AnimationFrame(new Rectangle(0, 384, 160, 96)));
            deathanimation.AddFrame(new AnimationFrame(new Rectangle(160, 384, 160, 96)));
            deathanimation.AddFrame(new AnimationFrame(new Rectangle(320, 384, 160, 96)));
            deathanimation.AddFrame(new AnimationFrame(new Rectangle(480, 384, 160, 96)));
            deathanimation.AddFrame(new AnimationFrame(new Rectangle(640, 384, 160, 96)));
            deathanimation.AddFrame(new AnimationFrame(new Rectangle(800, 384, 160, 96)));
            */
        }


    }
}
