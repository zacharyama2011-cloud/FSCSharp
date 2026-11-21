using FSCSharp;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Numerics;
using System.Text;

namespace BlastyBird
{
    public class Bird : VisibleGameObject
    {
        #region Constructors
        public Bird(Vector2 location)
        {
            Location = location;
            
            var texture = Raylib.LoadTexture("Resources/BirdSprite.png");
            Body = new Sprite(texture, 0.5f);
        }
        #endregion

        #region Overrides
        public override void Draw(float delta)
        {
            Body.Draw(Location);
        }

        public override void Update(float delta)
        {
            
        }
        #endregion

        #region Properties
        public Sprite Body { get; set; }
        public Vector2 Location { get; set; }
        #endregion

    }
}
