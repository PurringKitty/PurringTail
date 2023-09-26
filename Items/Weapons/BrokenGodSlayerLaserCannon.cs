using Microsoft.Xna.Framework;
using PurringTail.Content.Items.OresAndBars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.Weapons;

public class BrokenGodSlayerLaserCannon : ModItem
{
    // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

    public override void SetDefaults()
    {
        Item.damage = 16;
        Item.DamageType = DamageClass.Ranged;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 10;
        Item.useAnimation = 10;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.useTurn = true;
        Item.knockBack = 10;
        Item.value = Item.sellPrice(silver: 50);
        Item.rare = ItemRarityID.Red;
        Item.UseSound = SoundID.Item12;
        Item.autoReuse = true;
        Item.shoot = ProjectileID.LaserMachinegunLaser;
        Item.useAmmo = AmmoID.Gel;
        Item.shootSpeed = 100f;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.GoldBar, 4);
        recipe.AddIngredient<RustiumBar>(16);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }

    public override Vector2? HoldoutOffset()
    {
        Vector2 offset = new(6, 2);
        return offset;

    }
}