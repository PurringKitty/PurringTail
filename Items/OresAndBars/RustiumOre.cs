using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;

namespace PurringTail.Content.Items.OresAndBars;

public class RustiumOre : ModItem
{

    public override void SetDefaults()
    {
        Item.width = 10;
        Item.height = 7;
        Item.maxStack = 9999;
        Item.consumable = true;
        Item.value = Item.sellPrice(silver: 10);
        Item.createTile = ModContent.TileType<Content.Tiles.RustiumOreTile>();
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.autoReuse = true;
        Item.rare = ItemRarityID.Pink;
        ItemID.Sets.OreDropsFromSlime[Type] = (5, 15);
        Item.ResearchUnlockCount = 100;
        ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.IronOre, 1);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();
    }
}