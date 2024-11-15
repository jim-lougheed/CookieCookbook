namespace CookieCookbook.Recipes
{
    public partial class Recipe
    {
        public abstract class Cinnamon : Spice
        {
            public override int ID => 7;
            public override string Name => "Cinnamon";
        }
    }
}