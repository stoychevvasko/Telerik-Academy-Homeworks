namespace DeBuggerGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Animation        
    {
        #region fields

        // image
        Texture2D spriteStrip;
        
        // magnification scale                 
        private float scale;

        // time since last frame update 
        private int elapsedTime;

        // duration of frame display
        private int frameTime;

        // number of frames in animation
        private int frameCount;

        // index of current frame
        int currentFrame;

        // color of frame 
        Color color;

        // area of image strip to display
        Rectangle sourceRect = new Rectangle();

        // destination area for display
        Rectangle destinationRect = new Rectangle();

        #endregion

        #region properties

        // frame width 
        public int FrameWidth { get; set; }

        // frame height
        public int FrameHeight { get; set; }

        // state
        public bool ActiveState { get; set; }

        // continuous play vs single run
        public bool Looping { get; set; }

        // position
        public Vector2 Position { get; set; }

        #endregion

        #region methods

        public void Initialize(Texture2D texture, Vector2 position, int frameWidth, int frameHeight, int frameCount,
        int frametime, Color color, float scale, bool looping)
        {
            // keep local copy of values passed in
            this.color = color;
            this.FrameWidth = frameWidth;
            this.FrameHeight = frameHeight;
            this.frameCount = frameCount;
            this.frameTime = frametime;
            this.scale = scale;

            this.Looping = looping;
            this.Position = position;
            this.spriteStrip = texture;

            // set time to zero
            this.elapsedTime = 0;
            this.currentFrame = 0;

            // set the Animation to active by default
            this.ActiveState = true;
        }

        public void Update(GameTime gameTime)
        {
            // do not update game if not active
            if (this.ActiveState == false)
                return;

            // update elapsed time
            this.elapsedTime += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

            // if elapsed time is greater than frame time
            // switch frames
            if (this.elapsedTime > this.frameTime)
            {
                // move to next frame
                this.currentFrame++;

                // if currentFrame equals frameCount reset currentFrame to zero
                if (this.currentFrame == this.frameCount)
                {
                    this.currentFrame = 0;
                    // if not looping deactivate animation
                    if (this.Looping == false)
                        this.ActiveState = false;
                }

                // reset elapsed time to zero
                this.elapsedTime = 0;   
            }

            // grab correct frame in image strip by multiplying currentFrame index by frame width
            this.sourceRect = new Rectangle(this.currentFrame * this.FrameWidth, 0, this.FrameWidth, this.FrameHeight);

            // grab correct frame in image strip by multiplying currentFrame index by frame width
            this.destinationRect = new Rectangle((int)this.Position.X - (int)(this.FrameWidth * this.scale) / 2,
            (int)this.Position.Y - (int)(this.FrameHeight * this.scale) / 2,
            (int)(this.FrameWidth * this.scale),
            (int)(this.FrameHeight * this.scale));
        }
                
        public void Draw(SpriteBatch spriteBatch)
        {
            if (this.ActiveState)
            {
                spriteBatch.Draw(this.spriteStrip, this.destinationRect, this.sourceRect, this.color);
            }
        }

        #endregion

    }
}
