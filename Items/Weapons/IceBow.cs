using Terraria.ID;
using Terraria.ModLoader;

namespace AstralVoyage.Items.Weapons
{
    public class IceBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Don't let it melt!'");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 16;
            item.height = 32;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 0;
            item.value = 5;
            item.rare = 0;
            item.UseSound = SoundID.Item5;
            item.autoReuse = false;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 9f;
            item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 7);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
