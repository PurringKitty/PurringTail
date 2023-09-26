using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.OresAndBars;

namespace PurringTail.Content.Items.BossDrops;

public class OldBook1 : ModItem
{


    public override void SetDefaults()
    {
        Item.width = 15;
        Item.height = 15;
        Item.maxStack = 1;
        Item.material = true;
        Item.value = Item.sellPrice(gold: 50);
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.autoReuse = true;

    }

}



