using RecipeRover.ModelClasses;
using System.Data;

namespace RecipeRover.Interfaces
{
    public interface IRecipeDisplay
    {
        void DisplayRecipes(DataTable recipesTable, List<RecipeModelClass> recipes);
        void PopulateListBox();
    }
}
