namespace CookieCookbook.Recipes;

public partial class Recipe
{
    public class Chocolate : Ingredient
    {
        public override int ID => 4;
        public override string Name => "Chocolate";
        public override string PreparationInstructions => $"Melt in water bath. " + base.PreparationInstructions;
    }
}