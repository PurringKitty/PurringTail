using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using PurringTail.Content.Projectiles;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.MobLoot;

namespace PurringTail.Content.Items.Weapons
{
	public class GodSlayerWhip : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToWhip(ModContent.ProjectileType<GodSlayerWhipProjectile>(), 2345, 2, 20);
			Item.rare = ItemRarityID.Red;
            Item.value = Item.sellPrice(gold: 50);
            Item.channel = true;
			Item.autoReuse = true;
		}

		// Makes the whip receive melee prefixes
		public override bool MeleePrefix()
		{
			return true;
		}

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<OldGodSlayerWhip>(1);
            recipe.AddIngredient<TopiumBar>(20);
            recipe.AddIngredient<CoreOfValhalla>(20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
	}
}