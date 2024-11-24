
using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileStorage;
using CookieCookbook.Recipes;
using static CookieCookbook.Recipes.Recipe;

try
{
    const FileFormat format = FileFormat.Txt;
    IIngredientsRegister ingredientsRegister = new IngredientsRegister();
    IStringsRepository stringsRepository = format == FileFormat.Txt ? new StringsTextualRepository() : new StringsJSONRepository();

    const string FileName = "recipes";
    var fileMetadata = new FileMetadata(FileName, format);

    var cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(stringsRepository, ingredientsRegister), new RecipesConsoleUserInteraction(ingredientsRegister));
    cookiesRecipesApp.Run(fileMetadata.ToPath());
}
catch (Exception exception)
{
    Console.WriteLine("Sorry! The application experienced an unexpected error and will have to be closed." +
        "Error: " + exception.Message);
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}




