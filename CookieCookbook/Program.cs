
using System.Text.Json;
using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileStorage;
using CookieCookbook.Recipes;
using Microsoft.VisualBasic;
using static CookieCookbook.Recipes.Recipe;

const FileFormat format = FileFormat.Txt;
IIngredientsRegister ingredientsRegister = new IngredientsRegister();
IStringsRepository stringsRepository = format == FileFormat.Txt ? new StringsTextualRepository() : new StringsJSONRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, format);

var cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(stringsRepository, ingredientsRegister), new RecipesConsoleUserInteraction(ingredientsRegister));
cookiesRecipesApp.Run(fileMetadata.ToPath());



