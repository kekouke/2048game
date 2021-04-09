using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using System;

namespace _2048game
{
    internal class GameGrid : IGameEntity
    {
        private readonly int ROW_SIZE = 4;
        private readonly int COL_SIZE = 4;

        private Dictionary<int, Texture2D> _tilesTexture;
        private List<Tile> _tiles;

        public static readonly Point offset = new Point(18, 138);

        public GameGrid()
        {
            _tilesTexture = new Dictionary<int, Texture2D>();
            _tiles = new List<Tile>() { new Tile(new Vector2(18, 138)) };
        }

        public void LoadContent(ContentManager content)
        {
            for (int i = 2; i <= 2048; i *= 2)
            {
                _tilesTexture.Add(i, content.Load<Texture2D>("tiles/block_" + i));
            }
        }

        public void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.W))
            {
                MoveUp();
            }
            else if (keyboardState.IsKeyDown(Keys.D))
            {
                MoveDown();
            }
            else if (keyboardState.IsKeyDown(Keys.S))
            {
                MoveRight();
            }
            else if (keyboardState.IsKeyDown(Keys.A))
            {
                MoveLeft();
            }
        }

        private void MoveUp()
        {
            throw new NotImplementedException();
        }

        private void MoveDown()
        {
            throw new NotImplementedException();
        }

        private void MoveLeft()
        {
            throw new NotImplementedException();
        }

        private void MoveRight()
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var tile in _tiles)
            {
                spriteBatch.Draw(_tilesTexture[2], tile.Position, Color.White);
            }

            /*            spriteBatch.Draw(_tilesTexture[512], new Vector2(18, 138), Color.White);
                        spriteBatch.Draw(_tilesTexture[4], new Vector2(98, 138), Color.White);
                        spriteBatch.Draw(_tilesTexture[4], new Vector2(98, 218), Color.White);*/
        }
    }
}
