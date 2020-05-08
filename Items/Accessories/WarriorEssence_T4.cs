using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Accessories
{
	public class WarriorEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence");
			Tooltip.SetDefault("The Essence of monsters compressed into a form that imbues the user with some power.\nGrants +10% melee damage");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 0, 0, 25);
            item.rare = 1;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.meleeDamage += 0.10f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 25);
			recipe.AddIngredient(ItemID.Ruby, 1);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}