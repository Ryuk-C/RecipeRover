using System.Data.SQLite;
using System.Data;

namespace RecipeRover.Database
{
    public class DatabaseHelper
    {

        private string connectionString = @"Data Source=C:\Users\48572\source\repos\RecipeRover\RecipeRover\Files\recipes.db;Version=3;";

        private void OpenConnection(SQLiteConnection connection)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection(SQLiteConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public DataTable fetchRecipeList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                OpenConnection(connection);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM recipe_list", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public void AddRecipe(string name, string prepTime, string Ingredients, string Instructions, string ImageUrl, string YoutubeUrl, string CreationDate)
        {
            using (var connection = new SQLiteConnection(connectionString))
            
            using (var command = new SQLiteCommand("INSERT INTO recipe_list (name, prepTime, ingredients, instruction, imageUrl, youtubeUrl, creationDate) " +
                                                   "VALUES (@Name, @PreparationTime, @Ingredients, @Instructions, @ImageUrl, @YoutubeUrl, @CreationDate)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PreparationTime", prepTime);
                command.Parameters.AddWithValue("@Ingredients", Ingredients);
                command.Parameters.AddWithValue("@Instructions", Instructions);
                command.Parameters.AddWithValue("@ImageUrl", ImageUrl);
                command.Parameters.AddWithValue("@YoutubeUrl", YoutubeUrl);
                command.Parameters.AddWithValue("@CreationDate", CreationDate);

                command.ExecuteNonQuery();
            }
        }

        public void EditRecipe(int recipeId, string name, string prepTime, string Ingredients, string Instructions, string ImageUrl, string YoutubeUrl, string CreationDate)
        {
            string query = "UPDATE recipe_list SET name = @Name, prepTime = @PreparationTime, ingredients = @Ingredients, " +
                           "instruction = @Instructions, imageUrl = @ImageUrl, youtubeUrl = @YoutubeUrl, creationDate = @CreationDate " +
                           "WHERE id = @RecipeID";

            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeID", recipeId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PreparationTime", prepTime);
                command.Parameters.AddWithValue("@Ingredients", Ingredients);
                command.Parameters.AddWithValue("@Instructions", Instructions);
                command.Parameters.AddWithValue("@ImageUrl", ImageUrl);
                command.Parameters.AddWithValue("@YoutubeUrl", YoutubeUrl);
                command.Parameters.AddWithValue("@CreationDate", CreationDate);

                command.ExecuteNonQuery();
            }
        }

        public void RemoveRecipeById(int recipeId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand("DELETE FROM recipe_list WHERE id = @RecipeId", connection))
            {
                command.Parameters.AddWithValue("@RecipeId", recipeId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}