using Terraria.ID;
using Terraria.ModLoader;

namespace AstralVoyage.Items.Tools
{
	public class SandstoneAxe : ModItem
	{
		public override void SetDefaults()
		{
            item.damage = 4;
            item.melee = true;
            item.width = 32;
            item.height = 28;
            item.useTime = 32;
            item.useAnimation = 32;
            item.axe = 7;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 5;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sandstone, 9);
            recipe.AddRecipeGroup("Wood", 3);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
