#region File Description
//-----------------------------------------------------------------------------
// GameplayScreen.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameStateManagement;
using System.Collections.Generic;
#endregion

namespace GameStateManagementSample
{
    /// <summary>
    /// This screen implements the actual game logic. It is just a
    /// placeholder to get the idea across: you'll probably want to
    /// put some more interesting gameplay in here!
    /// </summary>
    public class GameplayScreen : GameScreen
    {
        public GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Player player;
        private KeyboardState currentKeyboardState;
        private KeyboardState previousKeyboardState;
        private MouseState currentMouseState;
        private MouseState previousMouseState;

        //enemy
        private Texture2D enemyTexture;
        private List<Enemy> enemies;
        // The rate at which the enemies appear
        TimeSpan enemySpawnTime;
        TimeSpan previousSpawnTime;

        // A random number generator
        Random random;

        //projectiles
        Texture2D projectileTexture;
        List<Projectile> projectiles;

        //solid objects
        Texture2D solidTexture;
        List<Solid> solids;

        //handle effects
        Texture2D explosionTexture;
        List<Animation> explosions;

        //Number that holds the player score
        int score;
        // The font used to display UI elements
        SpriteFont font;
        #region Fields

        ContentManager content;
        SpriteFont gameFont;

        //Vector2 playerPosition = new Vector2(100, 100);
        //Vector2 enemyPosition = new Vector2(100, 100);

        //Random random = new Random();

        float pauseAlpha;

        InputAction pauseAction;

        #endregion

        #region Initialization


        /// <summary>
        /// Constructor.
        /// </summary>
        public GameplayScreen()
        {
            TransitionOnTime = TimeSpan.FromSeconds(1.5);
            TransitionOffTime = TimeSpan.FromSeconds(0.5);

            pauseAction = new InputAction(
                new Buttons[] { Buttons.Start, Buttons.Back },
                new Keys[] { Keys.Escape },
                true);
            // TODO: Add your initialization logic here
            player = new Player();

            // Initialize the enemies list
            enemies = new List<Enemy>();
            // Set the time keepers to zero
            previousSpawnTime = TimeSpan.Zero;
            // Used to determine how fast enemy respawns
            enemySpawnTime = TimeSpan.FromSeconds(1.0f);

            //initialize projectiles
            projectiles = new List<Projectile>();

            //initialize effect explosions
            explosions = new List<Animation>();

            //initialize solid objects
            solids = new List<Solid>();
            solids.Add(new Solid());

            // Initialize our random number generator
            random = new Random();

            this.score = 0;
        }


        /// <summary>
        /// Load graphics content for the game.
        /// </summary>
        public override void Activate(bool instancePreserved)
        {
            if (!instancePreserved)
            {
                if (content == null)
                    content = new ContentManager(ScreenManager.Game.Services, "Content");

                gameFont = content.Load<SpriteFont>("gamefont");
                // Create a new SpriteBatch, which can be used to draw textures.
                spriteBatch = new SpriteBatch(ScreenManager.GraphicsDevice);

            // TODO: use this.Content to load your game content here

            //player
            Animation playerAnimation = new Animation();
            Texture2D playerTexture = content.Load<Texture2D>("shipAnimation");
            playerAnimation.Initialize(playerTexture, Vector2.Zero, 115, 69, 8, 30, Color.White, 1f, true);

            Vector2 playerPosition = new Vector2(ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.X, ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.Y
            + ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            player.Initialize(playerAnimation, playerPosition);

            //enemy
            enemyTexture = content.Load<Texture2D>("mineAnimation");

            //projectile
            projectileTexture = content.Load<Texture2D>("laser");

            //effect explosions
            explosionTexture = content.Load<Texture2D>("explosion");

            //solid objects texture
            solidTexture = content.Load<Texture2D>("solid");

            solids[0].Initialize(solidTexture, new Vector2(400,300));

            this.font = content.Load<SpriteFont>("gameFont");
                
                ScreenManager.Game.ResetElapsedTime();
            }

#if WINDOWS_PHONE
            if (Microsoft.Phone.Shell.PhoneApplicationService.Current.State.ContainsKey("PlayerPosition"))
            {
                playerPosition = (Vector2)Microsoft.Phone.Shell.PhoneApplicationService.Current.State["PlayerPosition"];
                enemyPosition = (Vector2)Microsoft.Phone.Shell.PhoneApplicationService.Current.State["EnemyPosition"];
            }
#endif
        }


        public override void Deactivate()
        {
#if WINDOWS_PHONE
            Microsoft.Phone.Shell.PhoneApplicationService.Current.State["PlayerPosition"] = playerPosition;
            Microsoft.Phone.Shell.PhoneApplicationService.Current.State["EnemyPosition"] = enemyPosition;
#endif

            base.Deactivate();
        }


        /// <summary>
        /// Unload graphics content used by the game.
        /// </summary>
        public override void Unload()
        {
            content.Unload();

#if WINDOWS_PHONE
            Microsoft.Phone.Shell.PhoneApplicationService.Current.State.Remove("PlayerPosition");
            Microsoft.Phone.Shell.PhoneApplicationService.Current.State.Remove("EnemyPosition");
#endif
        }


        #endregion

        #region Update and Draw


        /// <summary>
        /// Updates the state of the game. This method checks the GameScreen.IsActive
        /// property, so the game will stop updating when the pause menu is active,
        /// or if you tab away to a different application.
        /// </summary>
        public override void Update(GameTime gameTime, bool otherScreenHasFocus,
                                                       bool coveredByOtherScreen)
        {
            base.Update(gameTime, otherScreenHasFocus, false);

            // Gradually fade in or out depending on whether we are covered by the pause screen.
            if (coveredByOtherScreen)
                pauseAlpha = Math.Min(pauseAlpha + 1f / 32, 1);
            else
                pauseAlpha = Math.Max(pauseAlpha - 1f / 32, 0);

            if (IsActive)
            {
                // TODO: Add your update logic here
                // Save the previous state of the keyboard and game pad so we can determinesingle key/button presses
                this.previousKeyboardState = this.currentKeyboardState;
                this.previousMouseState = this.currentMouseState;

                // Read the current state of the keyboard and mouse and store it
                this.currentKeyboardState = Keyboard.GetState();
                this.currentMouseState = Mouse.GetState();


                //Update the player
                this.player.Update(this.currentKeyboardState, this.currentMouseState, ScreenManager, gameTime, this.solids);
                if (currentKeyboardState.IsKeyDown(Keys.Space))
                {
                    if (gameTime.TotalGameTime - Projectile.previousFireTime > Projectile.fireTime)
                    {
                        // Reset our current time
                        Projectile.previousFireTime = gameTime.TotalGameTime;

                        // Add the projectile, but add it to the front and center of the player
                        AddProjectile(player.Position + new Vector2(-player.Width / 2, -player.Height / 2));
                    }
                }
                //collision detection update
                UpdateCollision();
                //update enemies and add new ones/remove old
                UpdateEnemies(gameTime);
                UpdateProjectiles();
                UpdateExplosions(gameTime);

            }
        }


        /// <summary>
        /// Lets the game respond to player input. Unlike the Update method,
        /// this will only be called when the gameplay screen is active.
        /// </summary>
        public override void HandleInput(GameTime gameTime, InputState input)
        {
            PlayerIndex player;
            if (pauseAction.Evaluate(input, ControllingPlayer, out player))
            {
                ScreenManager.AddScreen(new PauseMenuScreen(), ControllingPlayer);
            }
        }


        /// <summary>
        /// Draws the gameplay screen.
        /// </summary>
        public override void Draw(GameTime gameTime)
        {
            // This game has a blue background. Why? Because!
            ScreenManager.GraphicsDevice.Clear(ClearOptions.Target,
                                               Color.CornflowerBlue, 0, 0);


            // TODO: Add your drawing code here
            spriteBatch.Begin();
            foreach (var solid in solids)
            {
                solid.Draw(spriteBatch);
            }
            //Draw player
            player.Draw(spriteBatch);
            //draw projectiles
            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Draw(spriteBatch);
            }
            // Draw the Enemies
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Draw(spriteBatch);
            }
            // Draw the explosions
            for (int i = 0; i < explosions.Count; i++)
            {
                explosions[i].Draw(spriteBatch);
            }
            // Draw the score
            spriteBatch.DrawString(font, "Score: " + this.score, new Vector2(ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.X, ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.Y), Color.White);
            // Draw the player health
            spriteBatch.DrawString(font, "Health: " + player.Health, new Vector2(ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.X, ScreenManager.GraphicsDevice.Viewport.TitleSafeArea.Y + 30), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
            if (TransitionPosition > 0 || pauseAlpha > 0)
            {
                float alpha = MathHelper.Lerp(1f - TransitionAlpha, 1f, pauseAlpha / 2);

                ScreenManager.FadeBackBufferToBlack(alpha);
            }
        }


        #endregion


        private void AddEnemy()
        {
            // Create the animation object
            Animation enemyAnimation = new Animation();

            // Initialize the animation with the correct animation information
            enemyAnimation.Initialize(enemyTexture, Vector2.Zero, 47, 61, 8, 30, Color.White, 1f, true);

            // Randomly generate the position of the enemy
            Vector2 position = new Vector2(ScreenManager.GraphicsDevice.Viewport.Width + enemyTexture.Width / 2, random.Next(100, ScreenManager.GraphicsDevice.Viewport.Height - 100));

            // Create an enemy
            Enemy enemy = new Enemy();

            // Initialize the enemy
            enemy.Initialize(enemyAnimation, position);

            // Add the enemy to the active enemies list
            enemies.Add(enemy);
        }

        private void UpdateEnemies(GameTime gameTime)
        {
            // Spawn a new enemy enemy every 1.5 seconds
            if (gameTime.TotalGameTime - previousSpawnTime > enemySpawnTime)
            {
                previousSpawnTime = gameTime.TotalGameTime;

                // Add an Enemy
                AddEnemy();
            }

            // Update the Enemies
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i].Update(gameTime);

                if (enemies[i].Active == false)
                {
                    if (enemies[i].Health <= 0)
                    {
                        // Add an explosion
                        AddExplosion(enemies[i].Position);
                        //Add to the player's score
                        score += enemies[i].Value;
                    }
                    else
                    {
                        score -= enemies[i].Value;
                    }
                    enemies.RemoveAt(i);
                }
            }
        }

        private void UpdateCollision()
        {
            // Use the Rectangle's built-in intersect function to
            // determine if two objects are overlapping
            Rectangle rectangle1;
            Rectangle rectangle2;

            // Projectile vs Enemy Collision
            for (int i = 0; i < projectiles.Count; i++)
            {
                for (int j = 0; j < enemies.Count; j++)
                {
                    // Create the rectangles we need to determine if we collided with each other
                    rectangle1 = new Rectangle((int)projectiles[i].Position.X - projectiles[i].Width / 2, (int)projectiles[i].Position.Y - projectiles[i].Height / 2, projectiles[i].Width, projectiles[i].Height);

                    rectangle2 = new Rectangle((int)enemies[j].Position.X - enemies[j].Width / 2, (int)enemies[j].Position.Y - enemies[j].Height / 2, enemies[j].Width, enemies[j].Height);

                    // Determine if the two objects collided with each other
                    if (rectangle1.Intersects(rectangle2))
                    {
                        enemies[j].Health -= projectiles[i].Damage;
                        projectiles[i].Active = false;
                    }
                }
            }

            // Only create the rectangle once for the player
            rectangle1 = new Rectangle((int)player.Position.X - player.Width / 2, (int)player.Position.Y - player.Height / 2, player.Width, player.Height);

            // Do the collision between the player and the enemies
            for (int i = 0; i < enemies.Count; i++)
            {
                rectangle2 = new Rectangle((int)enemies[i].Position.X, (int)enemies[i].Position.Y, enemies[i].Width, enemies[i].Height);

                // Determine if the two objects collided with each
                // other
                if (rectangle1.Intersects(rectangle2))
                {
                    // Subtract the health from the player based on
                    // the enemy damage
                    player.Health -= enemies[i].Damage;

                    // Since the enemy collided with the player
                    // destroy it
                    enemies[i].Health = 0;

                    // If the player health is less than zero we died
                    if (player.Health <= 0)
                        player.Active = false;
                }
            }

            foreach (var solid in solids)
            {
                rectangle1 = new Rectangle((int)solid.Position.X, (int)solid.Position.Y, solid.Width, solid.Height);

                // Do the collision between the solids and the enemies
                for (int i = 0; i < enemies.Count; i++)
                {
                    rectangle2 = new Rectangle((int)enemies[i].Position.X, (int)enemies[i].Position.Y, enemies[i].Width, enemies[i].Height);

                    // Determine if the two objects collided with each
                    // other
                    if (rectangle1.Intersects(rectangle2))
                    {
                        enemies[i].Health = 0;
                    }
                }
                for (int i = 0; i < projectiles.Count; i++)
                {
                    rectangle2 = new Rectangle((int)projectiles[i].Position.X - projectiles[i].Width / 2, (int)projectiles[i].Position.Y - projectiles[i].Height / 2, projectiles[i].Width, projectiles[i].Height);

                    // Determine if the two objects collided with each
                    // other
                    if (rectangle1.Intersects(rectangle2))
                    {
                        projectiles[i].Active = false;
                    }
                }
            }
        }

        private void AddProjectile(Vector2 position)
        {
            Projectile projectile = new Projectile();
            projectile.Initialize(ScreenManager.GraphicsDevice.Viewport, projectileTexture, position, player);
            projectiles.Add(projectile);
        }

        private void UpdateProjectiles()
        {
            // Update the Projectiles
            for (int i = projectiles.Count - 1; i >= 0; i--)
            {
                projectiles[i].Update();

                if (projectiles[i].Active == false)
                {
                    projectiles.RemoveAt(i);
                }
            }
        }

        private void AddExplosion(Vector2 position)
        {
            Animation explosion = new Animation();
            explosion.Initialize(explosionTexture, position, 134, 134, 12, 45, Color.White, 1f, false);
            explosions.Add(explosion);
        }

        private void UpdateExplosions(GameTime gameTime)
        {
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                explosions[i].Update(gameTime);
                if (explosions[i].Active == false)
                {
                    explosions.RemoveAt(i);
                }
            }
        }
    }
}
