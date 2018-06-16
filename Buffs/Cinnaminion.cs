using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace minions.Buffs
{
	public class Cinnaminion : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cinnaminion");
			Description.SetDefault("Tasty like bananas");
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.magicDamage -= 0.05f;
			player.manaCost -= 0.20f;
		}
	}
}