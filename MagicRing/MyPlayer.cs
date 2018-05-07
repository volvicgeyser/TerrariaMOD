using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MagicRing
{
    public class MyPlayer : ModPlayer
    {
        public Counter ringCounter = new Counter() ;
        public List<Projectile> ringProjectiles = new List<Projectile>();
    }
}