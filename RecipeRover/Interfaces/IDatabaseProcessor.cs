namespace RecipeRover.Interfaces
{
    public interface IDatabaseProcessor
    {
        void connectToDatabase();
        void AddRecipe();
        void RemoveRecipeById(int recipeId);
        void UpdateRecipeById(int recipeId);
    }
}
