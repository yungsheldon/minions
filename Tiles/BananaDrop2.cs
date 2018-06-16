using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace minions.Tiles
{
    public class BananaDropTwo : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (type == 75) //5% chance that break large jungle flowers will drop a banana
            {
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    return false;
                }
            }
            return true;
		}
	}
}