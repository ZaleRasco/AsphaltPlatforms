using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AsphaltPlatforms.Items.Placeable
{
	public class AsphaltPlatformItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Asphalt Platform");
			Tooltip.SetDefault("Increases running speed");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.useTime = 10;
			item.useAnimation = 15;
			item.autoReuse = true;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("AsphaltPlatformTile");

		}

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.AsphaltBlock, 1);
			recipe1.AddTile(TileID.Blendomatic);
			recipe1.SetResult(this, 2);
			recipe1.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(this, 2);
			recipe2.AddTile(TileID.Blendomatic);
			recipe2.SetResult(ItemID.AsphaltBlock, 1);
			recipe2.AddRecipe();
		}
	}
}
