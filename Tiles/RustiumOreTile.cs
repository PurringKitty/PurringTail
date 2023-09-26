using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace PurringTail.Content.Tiles
{
	public class RustiumOreTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;

			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
			Main.tileShine[Type] = 900;
			Main.tileShine2[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 150;

            AddMapEntry(new Color(222, 155, 113), Language.GetText("Rustium"));

            DustType = 84;
            HitSound = SoundID.Tink;

            MineResist = 4f;
            MinPick = 35;
		}
	}
}