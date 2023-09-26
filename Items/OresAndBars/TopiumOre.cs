using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;

namespace PurringTail.Content.Items.OresAndBars;

public class TopiumOre : ModItem
{


    public override void SetDefaults()
    {
        Item.width = 10;
        Item.height = 7;
        Item.maxStack = 9999;
        Item.consumable = true;
        Item.value = Item.sellPrice(gold: 10);
        Item.createTile = ModContent.TileType<Content.Tiles.TopiumOreTile>();
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.autoReuse = true;
        Item.rare = ItemRarityID.Cyan;
        ItemID.Sets.OreDropsFromSlime[Type] = (1, 6);
        Item.ResearchUnlockCount = 100;
        ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.IronOre, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
}