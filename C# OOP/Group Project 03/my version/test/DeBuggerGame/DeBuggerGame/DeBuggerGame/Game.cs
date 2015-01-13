namespace DeBuggerGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Audio;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.GamerServices;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Media;

    public class Game : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        
        // represents player
        private Player player;        

        // texture used
        private string playerTexture = "maleFigure_walk";
        
        // list of objects to draw
        private Banana banana;
        
        // banana texture
        private string bananaTexture = "banana";

        // keyboard states used to determine key presses
        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;
        
        // movement speed for player
        private float playerMoveSpeed;

        // image for static background
        Texture2D mainBackground;

        public Animation PlayerAnimation;
        public Texture2D BananaAnimation;

        // enemies
        Texture2D Ant;
        Texture2D AntFire;
        Texture2D Moth;
        Texture2D MothFire;
        Texture2D Fly;
        Texture2D FlyFire;
        List<Enemy> enemies;

        // enemy spawn rate
        TimeSpan enemySpawnTime;
        TimeSpan previousSpawnTime;

        // random number generator
        public Random random;
        
        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // initialize player
            player = new Player();
                        
            // set player movement speed
            playerMoveSpeed = 2.7f;

            // Initialize enemies list
            enemies = new List<Enemy>();

            // Set the time keepers to zero
            previousSpawnTime = TimeSpan.Zero;

            // Used to determine how fast enemy respawns
            enemySpawnTime = TimeSpan.FromSeconds(0.7f);

            // Initialize our random number generator
            random = new Random();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {            
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load the player resources
            PlayerAnimation = new Animation();
            Texture2D playerTexture = Content.Load<Texture2D>("maleFigure_walk");            
            PlayerAnimation.Initialize(playerTexture, Vector2.Zero, playerTexture.Width / 8, playerTexture.Height, 8, 80, Color.White, 1, true);

            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width / 2, GraphicsDevice.Viewport.TitleSafeArea.Y
            + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            player.Initialize(PlayerAnimation, playerPosition);

            // load background resources

            mainBackground = Content.Load<Texture2D>("circuitBoard");

            Ant = Content.Load<Texture2D>("ant");
            AntFire = Content.Load<Texture2D>("ant_ghost");
            Moth = Content.Load<Texture2D>("moth");
            MothFire = Content.Load<Texture2D>("moth_ghost");
            Fly = Content.Load<Texture2D>("fly");
            FlyFire = Content.Load<Texture2D>("fly_ghost");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // save previous state of keyboard
            previousKeyboardState = currentKeyboardState;

            // read current state of the keyboard and store it
            currentKeyboardState = Keyboard.GetState();            
            
            // update player
            UpdatePlayer(gameTime);

            // update enemies
            UpdateEnemies(gameTime);


            // ...


            base.Update(gameTime);
        }

        private void AddEnemy()
        {
            // create animation object
            Animation enemyAnimation = new Animation();

            // randomly generate enemy position 
            Vector2 position = new Vector2(GraphicsDevice.Viewport.Width + Ant.Width / 2, random.Next(100, GraphicsDevice.Viewport.Height - 100));


            int r = random.Next(1000);

            Enemy enemy = new Enemy();

            switch (r % 6)
            {
                case 0:
                    {
                        enemy = new Ant();                        
                        enemyAnimation.Initialize(Ant, Vector2.Zero, 32, 32, 16, 1000, Color.White, 1, true);
                    }
                    break;
                case 1: 
                    {
                        enemy = new FireAnt();                
                        enemyAnimation.Initialize(AntFire, Vector2.Zero, 32, 32, 16, 1000, Color.ForestGreen, 1, true);                                        
                    }
                    break;
                case 2: 
                    {
                        enemy = new Moth();
                        enemyAnimation.Initialize(Moth, Vector2.Zero, 40, 40, 12, 1000, Color.Red, 1, true);
                        
                    }
                    break;
                case 3:
                    {
                        enemy = new FireMoth();
                        enemyAnimation.Initialize(MothFire, Vector2.Zero, 40, 40, 12, 250, Color.Orange, 1, true);

                    }
                    break;
                case 4:
                    {
                        enemy = new Fly();
                        enemyAnimation.Initialize(Fly, Vector2.Zero, 60, 60, 24, 90, Color.DeepSkyBlue, 0.5f, true);

                    }
                    break;
                case 5:
                    {
                        enemy = new FireFly();
                        enemyAnimation.Initialize(FlyFire, Vector2.Zero, 60, 60, 24, 120, Color.Coral, 0.4f, true);

                    }
                    break;  
            }

            enemy.Initialize(enemyAnimation, position);
            enemies.Add(enemy);
            
           
        }
        
        private void UpdatePlayer(GameTime gameTime)
        {
            player.Update(gameTime);
            
            if (currentKeyboardState.IsKeyDown(Keys.Left))
            {
                player.X -= playerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.Right))
            {
                player.X += playerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.Up))
            {
                player.Y -= playerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.Down))
            {
                player.Y += playerMoveSpeed;
            }

            // make sure that the player does not go out of bounds
            player.X = MathHelper.Clamp(player.X, 20, GraphicsDevice.Viewport.Width - player.Width + 15);
            player.Y = MathHelper.Clamp(player.Y, 45, GraphicsDevice.Viewport.Height - player.Height + 40);
        }

        private void UpdateEnemies(GameTime gameTime)
        {
            // spawn a new enemy enemy every 1.5 seconds
            if (gameTime.TotalGameTime - previousSpawnTime > enemySpawnTime)
            {
                previousSpawnTime = gameTime.TotalGameTime;

                // add an enemy
                AddEnemy();
            }

            // update enemies
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i].Update(gameTime);

                if (enemies[i].Active == false)
                {
                    enemies.RemoveAt(i);
                }
            }
        }

        protected void UpdateSprite(GameTime gameTime, Texture2D sprite, ref Vector2 position)
        {
            
        }
        
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.Additive);
            
            // draw background
            spriteBatch.Draw(mainBackground, Vector2.Zero, Color.White);            

            // draw player            
            player.Draw(spriteBatch);

            // draw Enemies
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Draw(spriteBatch);
            }

            // ...
            
            spriteBatch.End();

            base.Draw(gameTime);                       
        }
    }
}
