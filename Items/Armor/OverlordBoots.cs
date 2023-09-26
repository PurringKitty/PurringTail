﻿using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using PurringTail.Content.Items.Armor.Vanity;

namespace PurringTail.Content.Items.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Legs value here will result in TML expecting a X_Legs.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Legs)]
	public class OverlordBoots : ModItem
	{
        public static readonly int MoveSpeedBonus = 10;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedBonus);
        public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
            Item.wornArmor = true;
            Item.value = Item.sellPrice(gold: 100); // How many coins the item is worth
			Item.rare = ItemRarityID.LightPurple; // The rarity of the item
			Item.defense = 8; // The amount of defense the item will give when equipped
            ArmorIDs.Body.Sets.HidesBottomSkin[Item.legSlot] = true; //i wanna die 
        }


        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += MoveSpeedBonus / 200f; // Increase the movement speed of the player

        }
                    public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient<TopiumBar>(15);
            recipe.AddIngredient(ItemID.BlueAcidDye, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
	}
}
