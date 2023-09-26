using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.OresAndBars;

namespace PurringTail.Content.Items.MobLoot;

public class CoreOfValhalla : ModItem
{


    public override void SetDefaults()
    {
        Item.width = 15;
        Item.height = 15;
        Item.maxStack = 9999;
        Item.material = true;
        Item.value = Item.sellPrice(gold: 5);
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.autoReuse = true;

    }
            public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient<TopiumBar>(5);
        recipe.AddIngredient<RustiumBar>(5);
        recipe.AddIngredient(ItemID.SoulofFlight, 5);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }


}
