using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace minions.Items
{
    public class BananaPeel : ModItem
    {
		 public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Banana Basket");
			Tooltip.SetDefault("You leave a trail of 'slipping' bananas, which push enemies back slightly and then disappear");
		}
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = 10000;
            item.rare = 1;
            item.accessory = true;
        }
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
			((minionsplayer)player.GetModPlayer(mod, "minionsplayer")).bananaPeel= true;
        }
    }
}