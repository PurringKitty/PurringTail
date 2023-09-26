using Microsoft.Xna.Framework;
using PurringTail.Content.Items.OresAndBars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Tools
{
    public class RustyPick : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 19;
            Item.useAnimation = 19;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.5f;
            Item.value = Item.sellPrice(silver: 50);
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.pick = 50;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RustiumBar>(15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
