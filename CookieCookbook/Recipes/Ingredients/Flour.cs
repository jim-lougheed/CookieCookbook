namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class Flour : Ingredient
        {
            public override string PreparationInstructions => $"Sieve. " + base.PreparationInstructions;
        }
    }
}