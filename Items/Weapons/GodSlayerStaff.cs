using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.MobLoot;

namespace PurringTail.Content.Items.Weapons;

public class GodSlayerStaff : ModItem
{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 800;
            Item.DamageType = DamageClass.Magic;
            Item.width = 60;
            Item.height = 76;
            Item.useTime = 9;
            Item.useAnimation = 9;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTurn = true;
            Item.knockBack = 20;
            Item.value = Item.sellPrice(gold: 50);
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item8;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.MagicMissile;
            Item.mana = 20;
            Item.shootSpeed = 100f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<BrokenGodSlayerStaff>(1);
            recipe.AddIngredient<TopiumBar>(20);
            recipe.AddIngredient<CoreOfValhalla>(20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            Vector2 offset = new(-18, 5);
            return offset;

        }
    }
