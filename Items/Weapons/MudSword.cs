using Terraria.ID;
using Terraria.ModLoader;

namespace AstralVoyage.Items.Weapons
{
	public class MudSword : ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Really cold and soggy'");  
        }

        public override void SetDefaults()
		{
			item.damage = 5;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 2;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MudBlock, 7);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
