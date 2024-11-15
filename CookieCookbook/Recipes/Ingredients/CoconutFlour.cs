namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class CoconutFlour : Flour
        {
            public override int ID => 2;
            public override string Name => "Coconut flour";
        }
    }
}