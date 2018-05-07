using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MagicRing.Items
{
	public class MagicRing : ModItem
	{
		public override string Texture
		{
			get
			{
                //Phantom Phoenix
				return "Terraria/Projectile_611";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Ring");
			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.magic = true;
			item.crit = 80;
			//item.melee = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType<Projectiles.MagicRing>() ;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
