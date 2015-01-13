namespace DeBuggerGame
{
    using System;            
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Item
        : GameObject
    {
        #region fields

        protected Animation animation;
        protected Vector2 position;

        #endregion

        #region properties

        public Animation Animation
        {
            get { return this.animation; }
            set { this.animation = value; }
        }

        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        #endregion

        #region constructors

        public Item()
            : base()
        {
        }

        #endregion
    }
}
