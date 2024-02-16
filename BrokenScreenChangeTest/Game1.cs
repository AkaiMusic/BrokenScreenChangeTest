using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrokenScreenChangeTest
{
    public class Game1 : Game
    {

        bool f11;

        private GraphicsDeviceManager _graphics;
        public static SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;

            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.F11) && !f11)
            {
                _graphics.ToggleFullScreen();
                _graphics.ApplyChanges();
                f11 = true;
            }
            else if (!Keyboard.GetState().IsKeyDown(Keys.F11))
                f11 = false;

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}
