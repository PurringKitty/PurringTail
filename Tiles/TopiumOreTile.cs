using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace PurringTail.Content.Tiles
{
	public class TopiumOreTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;

			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileShine[Type] = 1500;
			Main.tileShine2[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 500;

            AddMapEntry(new Color(94, 147, 150), Language.GetText("Topium"));

            DustType = 84;
            HitSound = SoundID.Tink;

            MineResist = 4f;
            MinPick = 225;
		}
	}
}