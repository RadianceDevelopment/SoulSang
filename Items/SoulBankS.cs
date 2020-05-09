using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class SoulBankS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Silver Soul Bank");
			Tooltip.SetDefault("A bundle of Silver Coins bound to some Souls.\nPersist after death.\nCannot be burned in Lava.\nNote: Mediumcore characters will still drop them, I can't program around that yet.");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.value = 0;
			item.rare = 1;
			item.maxStack = 40;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 5);
			recipe.AddIngredient(ItemID.SilverCoin, 25);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulBankS"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 2);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.SetResult(ItemID.SilverCoin, 25);
			recipe.AddRecipe();
		}
	}
}