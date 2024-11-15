namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class Butter : Ingredient
        {
            public override int ID => 3;
            public override string Name => "Butter";
            public override string PreparationInstructions => $"Melt on low heat. " + base.PreparationInstructions;
        }
    }
}