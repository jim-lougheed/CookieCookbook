namespace CookieCookbook.Recipes;


public partial class Recipe
{
    public class IngredientsRegister : IIngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient> {
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder()
    };

        public Ingredient GetById(int id)
        {
            foreach (var ingredient in All)
            {
                if (ingredient.ID == id)
                {
                    return ingredient;
                }
            }
            return null;
        }
    }
}