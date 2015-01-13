namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Moth
        : Enemy
    {
        // xp enemy gives to player
        public int value;


        public Moth()
            : base()
        {
            this.value = 3;

            // activate enemy 
            this.Active = true;

            // set enemy health 
            this.Health = 8;

            // set enemy damage
            this.Damage = 1;

            // set enemy speed
            this.Speed = 0.6f;
        }


    }
}
