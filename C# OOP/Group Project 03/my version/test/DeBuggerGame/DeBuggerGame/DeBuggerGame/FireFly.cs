namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class FireFly
        : Enemy
    {
        // xp enemy gives to player
        public int value;


        public FireFly()
            : base()
        {
            this.value = 5;

            // activate enemy 
            this.Active = true;

            // set enemy health 
            this.Health = 8;

            // set enemy damage
            this.Damage = 2;

            // set enemy speed
            this.Speed = 1.1f;
        }


    }
}
