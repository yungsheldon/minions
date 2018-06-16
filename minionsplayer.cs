using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace minions
{
	public class minionsplayer : ModPlayer
    {
		protected int bananaPeelTimer = 0;
		public bool bananaPeel = false;		
        public override void ResetEffects()
        {
			bananaPeel = false;
        }
		public override void PreUpdate()
		{
			bananaPeel = false;
		}
		public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
		{
			bananaPeelTimer++;
			bananaPeelTimer = 0;
			return true;
		}
		public override void PostUpdate()
	    {
			if (bananaPeel == true)
			{
				bananaPeelTimer++;
				if (bananaPeelTimer == 350)
				{
					bananaPeelTimer = 0;
					Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, 0f, mod.ProjectileType("BananaPeelProj"), 5, 15, player.whoAmI);
				}
			}
		}
	}
}
