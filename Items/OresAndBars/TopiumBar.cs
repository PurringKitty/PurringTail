using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Tiles;

namespace PurringTail.Content.Items.OresAndBars;

public class TopiumBar : ModItem
{


    public override void SetDefaults()
    {
        Item.width = 15;
        Item.height = 12;
        Item.maxStack = 9999;
        Item.consumable = true;
        Item.value = Item.sellPrice(gold: 100);
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.autoReuse = true;
        Item.rare = ItemRarityID.Cyan;
        Item.ResearchUnlockCount = 100;
        Item.createTile = ModContent.TileType<Content.Tiles.TopiumBlock>();
    }

    public override void AddRecipes()
    {
        CreateRecipe()
        .AddIngredient<TopiumOre>(10)
        .AddTile(TileID.AdamantiteForge)
        .Register();
    }
}