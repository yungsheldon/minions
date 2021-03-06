﻿using System;
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
	public class MinionBerryPancakes : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Minion Berry Pancakes");
			Description.SetDefault("Sauteed with banana");
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegen += 1;
		}
	}
}