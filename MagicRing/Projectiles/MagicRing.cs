using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MagicRing.Projectiles
{
	public class MagicRing : ModProjectile
	{
		public override string Texture
		{
			get
			{
                //Phantom Phoenix
				return "Terraria/Projectile_706";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MagicRing");
            Main.projFrames[projectile.type] = 8;
		}
		public override void SetDefaults()
		{
            projectile.width = 68;
            projectile.height = 72;
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
		}
        private int genCount = 0;

        private void SelectFrame()
        {
            //アニメーションを進める間隔
            projectile.frameCounter++;

            if (projectile.frameCounter > 5)
            {
                //実際にアニメーションを進める
                projectile.frame++;
                projectile.frameCounter = 0;
            }
            if (projectile.frame > 7)
            {
               projectile.frame = 0;
            }
        }

        public override void Kill(int timeLeft){
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            modPlayer.ringCounter.Dec();
        }
        float angle = (float)Math.PI/2 + (float)Math.PI ;
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");

            //同時に出せる数の制御
            if(projectile.ai[1] == 0){
                modPlayer.ringCounter.Inc();
                projectile.ai[1]++;
                //リストに登録
                modPlayer.ringProjectiles.Add(projectile) ;
            }
            if(modPlayer.ringCounter.Count > 3){
                Projectile first = modPlayer.ringProjectiles[0] ;
                modPlayer.ringProjectiles.Remove(first) ;
                first.Kill();
            }

            if (Main.player[projectile.owner].dead)
            {
                //プレイヤーがやられたら削除
                projectile.Kill();
            }

            //半径
            float r = 150f;
            //速度
            float v = 0.05f;

            projectile.position.X = player.position.X + (float)Math.Cos(angle)*r ;
            projectile.position.Y = player.position.Y + (float)Math.Sin(angle)*r ;
            angle+=v;
            if(angle > 2*Math.PI){
                angle = 0f;
            }
            projectile.rotation += v;

            this.SelectFrame();
            this.CreateDust();
        }
        private void CreateDust()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 66, 0f, 0f, 100, new Color(232, 138, 68), 1.5f) ;
            Main.dust[dust].velocity *= 0.1f;
            if(projectile.velocity == Vector2.Zero){
                Main.dust[dust].velocity.Y -= 1f;
                Main.dust[dust].scale=1.2f;
            }
            else{
                Main.dust[dust].velocity += projectile.velocity * 0.2f ;
            }
            Main.dust[dust].position.X = projectile.Center.X + 4f + (float)Main.rand.Next(-2, 3) ;
            Main.dust[dust].position.Y = projectile.Center.Y + (float)Main.rand.Next(-2,3) ;
            Main.dust[dust].noGravity = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            //target.AddBuff(BuffID.Poisoned, 600);
            target.AddBuff(BuffID.OnFire, 60);
            //target.AddBuff(BuffID.Cursed, 600);
            //target.AddBuff(BuffID.Ichor, 600);
            //target.AddBuff(BuffID.Frostburn, 600);
            //target.AddBuff(BuffID.Slow, 600);
            //target.damage = 1 ;
        }
	}
}
