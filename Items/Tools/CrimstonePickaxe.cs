using Terraria.ID;
using Terraria.ModLoader;

namespace AstralVoyage.Items.Tools
{
	public class CrimstonePickaxe : ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Seems red'");  //The (English) text shown below your weapon's name
        }
        public override void SetDefaults()
		{
            item.damage = 7;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 22;
            item.useAnimation = 22;
            item.pick = 33;    //pickaxe power
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 5;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 12);
            recipe.AddRecipeGroup("Wood", 4);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
