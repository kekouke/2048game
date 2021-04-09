using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2048game
{
    internal class Tile
    {
        public Vector2 Position { get; private set; }
        public TileStatus Status { get; set; }
        public int Value { get; private set; }

        private Texture2D _texture;

        public Tile(Vector2 position)
        {
            Status = TileStatus.Common;
            Position = position;
            Value = 2;
        }

        public void SetTexture(Texture2D texture)
        {
            _texture = texture;
        }

        public void Upgrade()
        {
            Status = TileStatus.Common;
            Value <<= 1;
        }
    }
}
