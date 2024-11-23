namespace CookieCookbook.Recipes;

public partial class Recipe
{
    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructions => $"Take half a teaspoon. " + base.PreparationInstructions;
    }
}