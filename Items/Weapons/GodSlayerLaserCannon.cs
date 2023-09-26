using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.Weapons;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.MobLoot;

namespace PurringTail.Content.Items.Weapons;

public class GodSlayerLaserCannon : ModItem
{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 964;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 4;
            Item.useAnimation = 4;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTurn = false;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(gold: 50);
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
            recipe.AddIngredient<BrokenGodSlayerLaserCannon>(1);
            recipe.AddIngredient<TopiumBar>(20);
            recipe.AddIngredient<CoreOfValhalla>(20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            Vector2 offset = new(6, 2);
            return offset;

        }
    }
