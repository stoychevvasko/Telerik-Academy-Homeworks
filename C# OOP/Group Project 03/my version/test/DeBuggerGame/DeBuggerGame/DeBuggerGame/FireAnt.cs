﻿namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class FireAnt
        : Enemy
    {
        // xp enemy gives to player
        public int value;


        public FireAnt()
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
            this.Speed = 0.8f;
        }


    }
}
