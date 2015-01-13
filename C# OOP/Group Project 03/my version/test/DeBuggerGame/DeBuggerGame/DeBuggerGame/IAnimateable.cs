namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public interface IAnimateable
    {
        #region IAnimateable implementation

        void Initialize(Animation animation, Vector2 position);

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch);

        #endregion
    }
}
