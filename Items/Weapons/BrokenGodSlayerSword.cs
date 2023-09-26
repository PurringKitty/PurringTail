using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.OresAndBars;

namespace PurringTail.Content.Items.Weapons;

public class BrokenGodSlayerSword : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Melee;
            Item.width = 42;
            Item.height = 54;
            Item.useTime = 8;
            Item.useAnimation = 8;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(silver: 50);
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.GoldBar, 7);
        recipe.AddIngredient<RustiumBar>(16);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        }
    }
