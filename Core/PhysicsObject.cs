﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using tainicom.Aether.Physics2D.Content;
using tainicom.Aether.Physics2D.Dynamics;

namespace AetheriumMono.Core
{
    public class PhysicsObject : GameObject
    {
        public Body Body { get; set; }
        public override Vector2 Position => Body.Position;
        public override float Rotation => Body.Rotation;
        public Vector2 Forward => new Vector2(-Mathf.Sin(Body.Rotation), Mathf.Cos(Body.Rotation));
        public Vector2 Right => new Vector2(Mathf.Cos(Body.Rotation), Mathf.Sin(Body.Rotation));
        public VertexPositionColor[] Vertices { get; set; }
        public short[] Indices { get; set; }
        public short[] LineIndices { get; set; }
    }
}
