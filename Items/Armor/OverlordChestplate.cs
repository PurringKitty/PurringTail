using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using PurringTail.Content.Items.Armor.Vanity;

namespace PurringTail.Content.Items.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Body value here will result in TML expecting X_Arms.png, X_Body.png and X_FemaleBody.png sprite-sheet files to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Body)]
	public class OverlordChestplate : ModItem
    	{
		public static int MaxManaIncrease = 300;
        public static int MaxMinionIncrease = 1;
        public static int MaxLifeIncrease = 100;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MaxManaIncrease, MaxMinionIncrease);


        public override void SetDefaults() {
			Item.width = 28; // Width of the item
			Item.height = 32; // Height of the item
            Item.wornArmor = true;
            Item.value = Item.sellPrice(gold: 100); // How many coins the item is worth
			Item.rare = ItemRarityID.LightPurple; // The rarity of the item
			Item.defense = 12; // The amount of defense the item will give when equipped
            ArmorIDs.Body.Sets.HidesTopSkin[Item.bodySlot] = true;


        
    }

    public override void UpdateEquip(Player player) {
        player.buffImmune[BuffID.Bleeding] = true; // Make the player immune to Bleeding
        player.statManaMax2 += MaxManaIncrease; // Increase how many mana points the player can have by 20
        player.maxMinions += MaxMinionIncrease; // Increase how many minions the player can have by one
        player.statLifeMax2 += MaxLifeIncrease;

    }
                   public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.BlueAcidDye, 1);
            recipe.AddIngredient<TopiumBar>(25);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
	}
}
