using PurringTail.Content.Items.MobLoot;
using PurringTail.Content.Items.OresAndBars;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class OldGodSlayerWings : ModItem
	{
	
		

		public override void SetStaticDefaults() {
			// These wings use the same values as the solar wings
			// Fly time: 180 ticks = 3 seconds
			// Fly speed: 9
			// Acceleration multiplier: 2.5
			ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(300, 11f, 4f);
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 20;
            Item.value = Item.sellPrice(gold: 25);
            Item.rare = ItemRarityID.LightPurple;
			Item.accessory = true;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 2f; // Falling glide speed
			ascentWhenRising = 1f; // Rising speed
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 10f;
			constantAscend = 0.135f;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 50)
                .AddIngredient<CoreOfValhalla>(20)
                .AddIngredient<TopiumBar>(1)
				.AddTile(TileID.Loom)
				.SortBefore(Main.recipe.First(recipe => recipe.createItem.wingSlot != -1)) // Places this recipe before any wing so every wing stays together in the crafting menu.
				.Register();
		}
	}
}
