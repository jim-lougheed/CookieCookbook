namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class WheatFlour : Flour
        {
            public override int ID => 1;
            public override string Name => "Wheat flour";
        }
    }
}