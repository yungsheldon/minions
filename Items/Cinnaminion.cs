using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;

namespace minions.Items
{
	public class Cinnaminion : ModItem
	{
		
		public override void SetDefaults()
        {
            item.UseSound = SoundID.Item2;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 99;
            item.value = 5500;
            item.rare = 1;
            item.buffType = mod.BuffType("Cinnaminion");
            item.buffTime = 36000;
		}
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cinnaminion");
           Tooltip.SetDefault("Decreases magic damage by 5%, but decreases mana cost by 20%");
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Banana" , 5);
			recipe.AddIngredient(ItemID.Fireblossom, 1);
			recipe.AddTile(96);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}
