using Microsoft.Xna.Framework;
using PurringTail.Content.Items.OresAndBars;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Weapons
{
    public class RustyStabber : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.useTime = 35;
            Item.useAnimation = 15;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 28;
            Item.knockBack = 2f;
            Item.crit = 2;
            Item.value = Item.sellPrice(silver: 50);
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RustiumBar>(13)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}