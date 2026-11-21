using FSCSharp;
using Raylib_cs;
using System.Numerics;

namespace BlastyBird;

public class BlastyBirdGame : Game<BlastyBirdGame>
{
    public BlastyBirdGame() : base("Blasty Bird", 1150, 750, Color.SkyBlue)
    {
        var bird = new Bird(new Vector2(WindowWidth*0.1f, WindowHeight/2f));
        GameObjects.Add(bird);
    }
}
