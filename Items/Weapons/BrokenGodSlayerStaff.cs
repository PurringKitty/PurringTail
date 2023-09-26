using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.OresAndBars;

namespace PurringTail.Content.Items.Weapons;

public class BrokenGodSlayerStaff : ModItem
{    
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 24;
            Item.DamageType = DamageClass.Magic;
            Item.width = 60;
            Item.height = 76;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTurn = true;
            Item.knockBack = 20;
            Item.value = Item.sellPrice(silver: 50);
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item8;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.MagicMissile;
            Item.mana = 1;
            Item.shootSpeed = 100f;
        }

        public override void AddRecipes()
        {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.GoldBar, 2);
        recipe.AddIngredient<RustiumBar>(18);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            Vector2 offset = new(-3 , 5);
            return offset;

        }
    }
