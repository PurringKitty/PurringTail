using Microsoft.Xna.Framework;
using PurringTail.Content.Items.OresAndBars;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Weapons
{
    public class TopiumCutter : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 5;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 45;
            Item.knockBack = 6f;
            Item.crit = 10;
            Item.value = Item.sellPrice(gold: 50);
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<TopiumBar>(19)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}