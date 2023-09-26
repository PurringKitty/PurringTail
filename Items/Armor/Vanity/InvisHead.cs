using PurringTail.Content.Items.Armor.Vanity;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Armor.Vanity
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Head value here will result in TML expecting a X_Head.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Head)]
	public class InvisHead : ModItem
	{
		

		public override void SetDefaults() {
			Item.width = 32; // Width of the item
			Item.height = 14; // Height of the item
            Item.vanity = true;
            Item.value = Item.sellPrice(gold: 100); // How many coins the item is worth
			Item.rare = ItemRarityID.LightPurple; // The rarity of the item
			Item.defense = 0; // The amount of defense the item will give when equipped

        }
                    public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.MothronBanner, 1);
            recipe.AddIngredient<TopiumBar>(1);
            recipe.AddTile(TileID.Loom);
            recipe.Register();

        }
    }
}

