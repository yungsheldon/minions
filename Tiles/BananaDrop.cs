using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace minions.Tiles
{
    public class BananaDrop : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (type == 323)
            {
                if (Main.rand.Next(5) == 0)
                {
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    return false;
                }
            }
            return true;
        }
    }
}