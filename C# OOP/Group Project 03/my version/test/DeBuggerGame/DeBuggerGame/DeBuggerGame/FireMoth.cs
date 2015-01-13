namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class FireMoth
        : Enemy
    {
        // xp enemy gives to player
        public int value;


        public FireMoth()
            : base()
        {
            this.value = 3;

            // activate enemy 
            this.Active = true;

            // set enemy health 
            this.Health = 8;

            // set enemy damage
            this.Damage = 3;

            // set enemy speed
            this.Speed = 0.3f;
        }


    }
}
