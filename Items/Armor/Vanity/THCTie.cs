﻿using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using PurringTail.Content.Items.Armor.Vanity;

namespace PurringTail.Content.Items.Armor.Vanity
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Body value here will result in TML expecting X_Arms.png, X_Body.png and X_FemaleBody.png sprite-sheet files to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Body)]
	public class THCTie : ModItem
	{
		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
            Item.vanity = true;
            Item.value = Item.sellPrice(platinum: 1); // How many coins the item is worth
			Item.rare = ItemRarityID.LightPurple; // The rarity of the item
			Item.defense = 0; // The amount of defense the item will give when equipped
		}

                   public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient<TopiumBar>(1);
            recipe.AddTile(TileID.Loom);
            recipe.Register();

        }
	}
}
