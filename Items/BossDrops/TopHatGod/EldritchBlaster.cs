using PurringTail.Content.Projectiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
using PurringTail.Content.Projectiles;
using PurringTail.Content.Items.MobLoot;
#pragma warning restore CS0105 // Using directive appeared previously in this namespace

namespace PurringTail.Content.Items.BossDrops;

	public class EldritchBlaster : ModItem
	{
		// You can use a vanilla texture for your item by using the format: "Terraria/Item_<Item ID>".


		public override void SetDefaults() {
        Item.damage = 800;
        Item.DamageType = DamageClass.Ranged;
        Item.width = 58;
        Item.height = 38;
        Item.useTime = 4;
        Item.useAnimation = 4;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.useTurn = false;
        Item.knockBack = 10;
        Item.value = Item.sellPrice(gold: 100);
        Item.rare = ItemRarityID.Red;
        Item.UseSound = SoundID.Item12;
        Item.autoReuse = true;
        Item.shoot = ProjectileID.TerrarianBeam;
        Item.useAmmo = AmmoID.Bullet;
        Item.shootSpeed = 100f;

		}
	}