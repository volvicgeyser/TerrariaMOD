using Terraria.ModLoader;

namespace MagicRing
{
	class MagicRing : Mod
	{
		public MagicRing()
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
