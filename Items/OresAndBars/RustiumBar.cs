using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;

namespace PurringTail.Content.Items.OresAndBars;

public class RustiumBar : ModItem
{


    public override void SetDefaults()
    {
        Item.width = 15;
        Item.height = 12;
        Item.maxStack = 9999;
        Item.consumable = true;
        Item.value = Item.sellPrice(silver: 50);
        Item.createTile = ModContent.TileType<Content.Tiles.RustiumBlock>();
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.autoReuse = true;
        Item.ResearchUnlockCount = 100;
        Item.rare = ItemRarityID.Pink;
    }

    public override void AddRecipes()
    {
        CreateRecipe()
        .AddIngredient<RustiumOre>(5)
        .AddTile(TileID.Furnaces)
        .Register();
    }
}