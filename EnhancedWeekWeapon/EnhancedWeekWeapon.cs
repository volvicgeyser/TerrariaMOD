using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EnhancedWeekWeapon
{
	class EnhancedWeekwWapon : Mod
	{
		public EnhancedWeekwWapon()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
