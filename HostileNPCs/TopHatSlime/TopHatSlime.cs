using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using PurringTail.Content.NPCs.HostileNPCs;
using PurringTail.Content.Items.MobLoot;
using Terraria.GameContent.ItemDropRules;
using PurringTail.Content.Items.Armor.Vanity;
using PurringTail.Content.Items.Accessories;
using Terraria.GameContent.Bestiary;

namespace PurringTail.Content.NPCs.HostileNPCs
{
    public class TopHatSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
          
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];

        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 15;
            NPC.damage = 5;
            NPC.defense = 50;
            NPC.lifeMax = 5000;
            NPC.value = 10000f;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.rarity = 4;
            AIType = NPCID.GreenSlime;
            AnimationType = NPCID.GreenSlime;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
       
        }


        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) =>
            // We can use AddRange instead of calling Add multiple times in order to add multiple items at once
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
				// Sets the spawning conditions of this NPC that is listed in the bestiary.
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,

				// Sets the description of this NPC that is listed in the bestiary.
				new FlavorTextBestiaryInfoElement("A Cute Little Slime That Wears A Top Hat It Found On The Floor Somewhere..."),
            });
        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if (NPC.frameCounter >= 20)
            {
                NPC.frameCounter = 0;
            }
            NPC.frame.Y = (int)NPC.frameCounter / 10 * frameHeight;
        }



        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Gel, Main.rand.Next(10, 200));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<THCTopHat>(), 1, true);
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<CoreOfValhalla>(), 20, true);
        }

    }
}