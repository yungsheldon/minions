using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace minions.Tiles
{
    public class BananaDropThree : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (type == 69) //2% chance that break jungle thorns will create a banana horde
            {
                if (Main.rand.Next(50) == 0)
                {
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Banana"));
                    return false;
                }
            }
            return true;
        }
	}
}