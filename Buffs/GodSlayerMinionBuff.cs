using Terraria;
using Terraria.ModLoader;
using PurringTail.Content;
using PurringTail.Content.Items.Weapons;
using PurringTail.Content.Projectiles;

namespace PurringTail.Content.Buffs
{
    public class GodSlayerMinionBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<GodSlayerMinionProjectile>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}