using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Projectiles;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria.GameInput;
using PurringTail.Content.Items.MobLoot;

namespace PurringTail.Content.Items.Weapons;

public class GodSlayerSword: ModItem
{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 1223;
            Item.DamageType = DamageClass.Melee;
            Item.width = 78;
            Item.height = 92;
            Item.useTime = 4;
            Item.useAnimation = 4;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(gold: 50);
            //Item.shoot = ModContent.ProjectileType<GodSlayerSwordSwingProjectile>();
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }


    public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<BrokenGodSlayerSword>(1);
            recipe.AddIngredient<TopiumBar>(20);
            recipe.AddIngredient<CoreOfValhalla>(20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
