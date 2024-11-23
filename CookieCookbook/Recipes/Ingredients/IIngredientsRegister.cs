namespace CookieCookbook.Recipes;


public partial class Recipe
{
    public interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }

        Ingredient GetById(int id);
    }
}