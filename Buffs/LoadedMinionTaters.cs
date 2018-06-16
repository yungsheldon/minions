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
	public class LoadedMinionTaters : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Loaded Minion Taters");
			Description.SetDefault("100% organic minion fillet");
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.meleeSpeed += 0.10f;
			player.meleeCrit += 10;
		}
	}
}
