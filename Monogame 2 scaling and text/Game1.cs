using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Threading;

namespace Monogame_2_scaling_and_text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Random generator;

        Rectangle redRect;
        Rectangle greenRect;
        Rectangle bgParkingLot;
        Rectangle carRect;
        Rectangle policeRect;
        Rectangle blueCarRect;
        Rectangle batmobileRect;
        Rectangle policemanRect;
        Rectangle batmanRect;

        Rectangle window;

        Texture2D rectangleTexture;
        Texture2D circleTexture;
        Texture2D parkingTexture;
        Texture2D carTexture;
        Texture2D policeTexture; 
        Texture2D blueCarTexture;
        Texture2D batmobileTexture;
        Texture2D policemanTexture;
        Texture2D batmanTexture;

        SpriteFont messageFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            policeRect = new Rectangle(180,30,225,225);
            blueCarRect = new Rectangle(80, 250, 225, 225);
            batmobileRect = new Rectangle(300, 250, 350, 150);
            batmanRect = new Rectangle(670, 250, 125, 125);
            policemanRect = new Rectangle(260, 30, 125, 125);
            carRect = new Rectangle(80, 30, 225, 225);
            window = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);  
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            messageFont = Content.Load<SpriteFont>("messageFont");
            parkingTexture = Content.Load<Texture2D>("Parking Lot");
            carTexture = Content.Load<Texture2D>("redcar-removebg-preview");
            policeTexture = Content.Load<Texture2D>("Police-removebg-preview");
            blueCarTexture = Content.Load<Texture2D>("Blue_car-removebg-preview");
            batmobileTexture = Content.Load<Texture2D>("batmobile");
            batmanTexture = Content.Load<Texture2D>("batman");
            policemanTexture = Content.Load<Texture2D>("Policeman");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            bool done = false;
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(parkingTexture, window, Color.White);
            _spriteBatch.Draw(blueCarTexture, blueCarRect, Color.White);
            _spriteBatch.Draw(batmobileTexture, batmobileRect, Color.White);
            _spriteBatch.Draw(policemanTexture, policemanRect, Color.White);
            _spriteBatch.Draw(batmanTexture, batmanRect, Color.White);
            _spriteBatch.Draw(policeTexture, new Vector2(carRect.X + 280, carRect.Y), Color.White);
            _spriteBatch.Draw(carTexture, new Vector2(carRect.X + 420, carRect.Y), Color.White);
            _spriteBatch.Draw(carTexture, new Vector2(carRect.X + 560, carRect.Y), Color.White);
            _spriteBatch.Draw(carTexture, carRect, Color.White);
            _spriteBatch.DrawString(messageFont, "Batman!", new Vector2(10, 10), Color.White);
            _spriteBatch.DrawString(messageFont, "I'm Batman!", new Vector2(425, 375), Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}