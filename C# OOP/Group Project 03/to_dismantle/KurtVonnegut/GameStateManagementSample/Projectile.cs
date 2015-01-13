using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameStateManagementSample
{
    public class Projectile
    {
        private const int DAMAGE = 15;
        private const float SPEED = 20;
        private const float FIRE_DELAY = 0.15f;

        // The rate of fire of the projectile laser
        public static TimeSpan fireTime;
        public static TimeSpan previousFireTime;

        // Image representing the Projectile
        public Texture2D Texture;

        // Position of the Projectile relative to the upper left side of the screen
        public Vector2 Position;

        // State of the Projectile
        public bool Active;

        // The amount of damage the projectile can inflict to an enemy
        public int Damage;

        // Represents the viewable boundary of the game
        Viewport viewport;

        // Get the width of the projectile ship
        public int Width
        {
            get { return Texture.Width; }
        }

        // Get the height of the projectile ship
        public int Height
        {
            get { return Texture.Height; }
        }

        public float Rotation { get; set; }

        // Determines how fast the projectile moves
        float projectileMoveSpeed;


        public void Initialize(Viewport viewport, Texture2D texture, Vector2 position, IRotatable shooter)
        {
            this.Texture = texture;
            this.Position = position;
            this.viewport = viewport;
            this.Rotation = shooter.Rotation;
            // Set the laser to fire every quarter second
            fireTime = TimeSpan.FromSeconds(FIRE_DELAY);

            this.Active = true;

            this.Damage = DAMAGE;

            this.projectileMoveSpeed = SPEED;

        }
        public void Update()
        {
            // can move sideways by rotation
            float offsetX = (float)Math.Cos(Rotation);
            float offsetY = (float)Math.Sin(Rotation);
            Position.X += projectileMoveSpeed * offsetX;
            Position.Y += projectileMoveSpeed * offsetY;

            // Deactivate the bullet if it goes out of screen
            if (Position.X + Texture.Width / 2 > viewport.Width)
                Active = false;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, this.Rotation, new Vector2(Width / 2, Height / 2), 1f, SpriteEffects.None, 0f);
        }
    }
}
