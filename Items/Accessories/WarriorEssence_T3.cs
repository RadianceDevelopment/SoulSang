using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence III");
			Tooltip.SetDefault("The Essence starts to hum, as if preparing for something...\nGrants +15% melee damage and 10% melee speed\nBoosts melee critical chance by 3%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 4;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.meleeDamage+= 0.15f;
			player.meleeSpeed+= 0.10f;
			player.meleeCrit+= 3;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T2"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 15);
			recipe.AddIngredient(ItemID.HellstoneBar, 3);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}