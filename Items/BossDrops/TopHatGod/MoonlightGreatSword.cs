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

namespace PurringTail.Content.Items.BossDrops;

public class MoonlightGreatSword : ModItem
{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.PurringTale.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 1000;
            Item.DamageType = DamageClass.Melee;
            Item.width = 58;
            Item.height = 64;
            Item.useTime = 4;
            Item.useAnimation = 4;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(gold: 100);
        //Item.shoot = ModContent.ProjectileType<GodSlayerSwordSwingProjectile>();
        Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
}
