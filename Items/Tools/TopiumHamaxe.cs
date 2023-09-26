using Microsoft.Xna.Framework;
using PurringTail.Content.Items.OresAndBars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Tools
{
    public class TopiumHamaxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 200;
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 5;
            Item.useAnimation = 8;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 100f;
            Item.value = Item.sellPrice(gold: 50);
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.axe = 55;
            Item.hammer = 300;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            //some dirt effect
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<TopiumBar>(15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
