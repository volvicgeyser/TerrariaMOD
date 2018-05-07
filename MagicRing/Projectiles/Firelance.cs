using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace SuperMinion.Projectiles
{
	public class Firelance : ModProjectile
	{
		public override string Texture
		{
			get
			{
				return "Terraria/Projectile_85";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DebuffBall");
		}
		public override void SetDefaults()
		{
            projectile.width = 40;
            projectile.height = 40;
            projectile.penetrate = -1;
            projectile.timeLeft = 400;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
		}
        private int genCount = 0;

        public override void AI()
        {
        }


        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 600);
            target.AddBuff(BuffID.OnFire, 600);
            target.AddBuff(BuffID.Cursed, 600);
            target.AddBuff(BuffID.Ichor, 600);
            target.AddBuff(BuffID.Frostburn, 600);
            target.AddBuff(BuffID.Slow, 600);
            //target.damage = 1 ;
        }
	}
}
