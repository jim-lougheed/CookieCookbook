namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class Sugar : Ingredient
        {
            public override int ID => 5;
            public override string Name => "Sugar";
        }
    }
}