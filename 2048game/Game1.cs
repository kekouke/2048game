using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2048game
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _background;
        private Texture2D _tile;

        private readonly GameGrid _gameGrid;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _gameGrid = new GameGrid();

            _graphics.PreferredBackBufferWidth = 360;  // set this value to the desired width of your window
            _graphics.PreferredBackBufferHeight = 480;   // set this value to the desired height of your window
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _background = Content.Load<Texture2D>("background");

            _tile = Content.Load<Texture2D>("tiles/block_64");
            _gameGrid.LoadContent(Content);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _gameGrid.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_background, Vector2.Zero, Color.White);
/*            _spriteBatch.Draw(_tile, new Vector2(25, 145), Color.White);
            _spriteBatch.Draw(_tile, new Vector2(109, 145), Color.White);
            _spriteBatch.Draw(_tile, new Vector2(193, 145), Color.White);
            _spriteBatch.Draw(_tile, new Vector2(277, 145), Color.White);*/

            _gameGrid.Draw(gameTime, _spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
