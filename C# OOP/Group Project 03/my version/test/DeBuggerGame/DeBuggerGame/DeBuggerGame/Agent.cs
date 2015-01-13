namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Agent
        : GameObject, IAnimateable
    {
        #region fields

        protected Animation animation;
        protected Vector2 position;
        protected int health;

        #endregion

        #region properties

        public int Width
        {
            get { return animation.FrameWidth; }
        }

        public int Height
        {
            get { return animation.FrameHeight; }
        }

        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public float X
        {
            get { return this.position.X; }
            set { this.position.X = value; }
        }

        public float Y
        {
            get { return this.position.Y; }
            set { this.position.Y = value; }
        }

        public bool Active { get; set; }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0 || value > 8)
                {
                    throw new System.ArgumentOutOfRangeException("Health must be in the range [0;8]!");
                }
                this.health = value;
            }
        }

        #endregion

        #region constructors

        public Agent()
            : base()
        {
        }

        #endregion

        #region IAnimateable implementation

        public void Initialize(Animation animation, Vector2 position)
        {
            this.animation = animation;
            this.Position = position;
            this.Active = true;
            this.Health = 8;
        }

        public void Update(GameTime gameTime)
        {
            this.animation.Position = this.Position;
            this.animation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.animation.Draw(spriteBatch);
        }

        #endregion
    }
}
