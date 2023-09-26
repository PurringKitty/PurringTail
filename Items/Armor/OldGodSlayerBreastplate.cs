using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Body value here will result in TML expecting X_Arms.png, X_Body.png and X_FemaleBody.png sprite-sheet files to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Body)]
	public class OldGodSlayerBreastplate : ModItem
	{
		public static int MaxManaIncrease = 50;
		public static int MaxMinionIncrease = 1;
		public static int MaxLifeIncrease = 50;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MaxManaIncrease, MaxMinionIncrease);

		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.value = Item.sellPrice(gold: 50); // How many coins the item is worth
			Item.rare = ItemRarityID.Orange; // The rarity of the item
			Item.defense = 15; // The amount of defense the item will give when equipped
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true; // Make the player immune to Fire
			player.statManaMax2 += MaxManaIncrease; // Increase how many mana points the player can have by 20
			player.maxMinions += MaxMinionIncrease; // Increase how many minions the player can have by one
			player.statLifeMax2 += MaxLifeIncrease;
		}

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldChainmail);
            recipe.AddIngredient<RustiumBar>(24);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
	}
}
