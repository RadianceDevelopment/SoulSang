using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulTargeter_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Targeter II");
			Tooltip.SetDefault("You've added more Souls into the housing to double the efficiency\nGrants +6% Critical Chance");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 4;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicCrit+= 6;
			player.meleeCrit+= 6;
			player.rangedCrit+= 6;
			
			player.thrownCrit+= 6;
			/*
			player.magicDamage+= 0.07f;
			player.meleeDamage+= 0.07f;
			player.rangedDamage+= 0.07f;
			player.minionDamage+= 0.07f;
		
			player.thrownDamage+= 0.07f;
			*/
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulTargeter_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 45);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.CobaltBar, 4);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulTargeter_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 45);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.PalladiumBar, 4);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}