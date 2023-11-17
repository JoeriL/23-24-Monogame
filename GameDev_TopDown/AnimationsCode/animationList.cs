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
        public Dictionary<Direction, GunIdleAnimation> gunidleanimationList = new Dictionary<Direction, GunIdleAnimation>();
        public Dictionary<Direction, ShootAnimation> shootanimationList = new Dictionary<Direction, ShootAnimation>();

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

            gunidleanimationList.Add(Direction.Up, new GunIdleAnimation(Direction.Up));
            gunidleanimationList.Add(Direction.Down, new GunIdleAnimation(Direction.Down));
            gunidleanimationList.Add(Direction.Left, new GunIdleAnimation(Direction.Left));
            gunidleanimationList.Add(Direction.Right, new GunIdleAnimation(Direction.Right));

            shootanimationList.Add(Direction.Up, new ShootAnimation(Direction.Up));
            shootanimationList.Add(Direction.Down, new ShootAnimation(Direction.Down));
            shootanimationList.Add(Direction.Left, new ShootAnimation(Direction.Left));
            shootanimationList.Add(Direction.Right, new ShootAnimation(Direction.Right));
        }
    }
}
