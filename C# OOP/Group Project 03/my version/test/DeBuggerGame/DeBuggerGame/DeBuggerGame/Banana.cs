

namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Banana
        : Consummable, IAnimateable
    {
        #region IAnimateable implementation

        public void Initialize(Animation animation, Vector2 position)
        {
            this.Animation = animation;
            this.Position = position;            
        }

        public void Update(GameTime gameTime)
        {
            this.Animation.Position = this.Position;
            this.Animation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {            
            this.Animation.Draw(spriteBatch);
        }

        #endregion
    }
}
