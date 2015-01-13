using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameStateManagement;

namespace GameStateManagementSample
{
    public class Player : IRotatable
    {
        private const int DEF_HP = 100;
        private const float INIT_MOVESPEED = 5.0f;
        private Vector2 initialPos;
        //fields
        
        //constructors
        public Player()
        {
            this.PlayerMoveSpeed = INIT_MOVESPEED;
            this.Rotation = 0;
        }
        //properties
        public float Rotation { get; set;}

        public float PlayerMoveSpeed { get; set; }
        public Animation PlayerAnimation { get; set; }

        // Position of the Player relative to the upper left side of the screen
        public Vector2 Position;

        // State of the player
        public bool Active { get; set; }

        // Amount of hit points that player has
        public int Health { get; set; }

        // Get the width of the player ship
        public int Width
        {
            get { return PlayerAnimation.FrameWidth; }
        }

        // Get the height of the player ship
        public int Height
        {
            get { return PlayerAnimation.FrameHeight; }
        }

        //methods
        public void Initialize(Animation animation, Vector2 position)
        {
            this.PlayerAnimation = animation;

            // Set the starting position of the player around the middle of the screen and to the back
            Position = position;
            this.initialPos = position;

            // Set the player to be active
            Active = true;

            // Set the player health
            Health = DEF_HP;
        }

        public void Update(KeyboardState currentKeyboardState, MouseState currentMouseState, ScreenManager game, GameTime gameTime, List<Solid> solids)
        {
            Vector2 oldPosition = this.Position;
            if (currentKeyboardState.IsKeyDown(Keys.A))
            {
                this.Position.X -= this.PlayerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.D))
            {
                this.Position.X += this.PlayerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.W))
            {
                this.Position.Y -= this.PlayerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.S))
            {
                this.Position.Y += this.PlayerMoveSpeed;
            }
            Rectangle rectangle1;
            Rectangle rectangle2;
            rectangle1 = new Rectangle((int)this.Position.X - this.Width / 2, (int)this.Position.Y - this.Height / 2, this.Width, this.Height);

            foreach (var solid in solids)
            {
                rectangle2 = new Rectangle((int)solid.Position.X + solid.Width, (int)solid.Position.Y + solid.Height, solid.Width, solid.Height);
                if (rectangle1.Intersects(rectangle2))
                {
                    this.Position = oldPosition;
                    break;
                }
            }

            if (this.Health <= 0)
            {
                this.Health = DEF_HP;
                this.Position = initialPos;
            }
            //rotates towards the mouse
            float distanceX = this.Position.X - this.Width / 2 - currentMouseState.X;
            float distanceY = this.Position.Y - this.Height / 2 - currentMouseState.Y;
            this.Rotation = (float)Math.Atan2(distanceY, distanceX) - MathHelper.Pi;

            this.Position.X = MathHelper.Clamp(this.Position.X, this.Width, game.GraphicsDevice.Viewport.Width);
            this.Position.Y = MathHelper.Clamp(this.Position.Y, this.Height, game.GraphicsDevice.Viewport.Height);
            PlayerAnimation.Position = Position;
            PlayerAnimation.Update(gameTime);
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            PlayerAnimation.Draw(spriteBatch, this);
            //spriteBatch.Draw(this.PlayerAnimation, this.Position, null, Color.White,this.Rotation, new Vector2(this.PlayerAnimation.Width/2, this.PlayerAnimation.Height/2) , 1f, SpriteEffects.None, 0f);
        }
    }
}
