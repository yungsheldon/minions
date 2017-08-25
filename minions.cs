using Terraria.ModLoader;

namespace minions
{
	class minions : Mod
	{
		public minions()
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
