using Terraria.ID;
using Terraria.ModLoader;

namespace AstralVoyage.Items.Weapons
{
    public class WoodenShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'This is terrible idea'");  
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 3;
            item.knockBack = 3;
            item.value = 5;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 7);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
