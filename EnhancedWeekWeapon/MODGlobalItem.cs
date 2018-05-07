using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EnhancedWeekWeapon.items
{
	class MODGlobalItem : GlobalItem
	{
        public override void SetDefaults(Item item)
        {
        	if (item.type == ItemID.CopperShortsword)
			{
				//ダメージ
				item.damage = 100;
				//射撃の種類
				item.shoot = ProjectileID.Flamelash;
			}

			//全武器強化
			//item.damage = item.damage * 2 ;

			//全武器弱体化
			//item.damage = item.damage * 0.3 ;
        }
	}
}
