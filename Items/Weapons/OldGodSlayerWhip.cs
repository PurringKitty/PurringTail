using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using PurringTail.Content.Projectiles;
using PurringTail.Content.Items.OresAndBars;

namespace PurringTail.Content.Items.Weapons
{
	public class OldGodSlayerWhip : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToWhip(projectileId: ModContent.ProjectileType<OldGodSlayerWhipProjectile>(), 23, 2, 10);
			Item.rare = ItemRarityID.Red;
            Item.value = Item.sellPrice(silver: 50);
            Item.channel = true;
			Item.autoReuse = true;
		}

		public override bool MeleePrefix()
		{
			return true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient<RustiumBar>(10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}