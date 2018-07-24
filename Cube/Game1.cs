#define DEBUG
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;

namespace Cube.Desktop {
  public class Game1 : Core {
    GraphicsDeviceManager graphics;

    public Game1() {
    }

    protected override void Initialize() {
      base.Initialize();
    }

    protected override void LoadContent() {
    }

    protected override void UnloadContent() {
    }

    protected override void Update(GameTime gameTime) {
      base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
      GraphicsDevice.Clear(Color.CornflowerBlue);
      base.Draw(gameTime);
    }
  }
}
