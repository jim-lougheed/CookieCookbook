namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class CocoaPowder : Ingredient
        {
            public override int ID => 8;
            public override string Name => "Cocoa powder";
        }
    }
}