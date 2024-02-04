using System.Data;
using System.Diagnostics;
using System.Net;
using RecipeRover.Database;
using RecipeRover.ModelClasses;
using RecipeRover.Interfaces;
namespace RecipeRover
{
    public partial class HomeForm : Form, IDatabaseProcessor, IRecipeDisplay
    {

        private List<RecipeModelClass> recipes = new List<RecipeModelClass>();
        private List<RecipeModelClass> filteredRecipesList = new List<RecipeModelClass>();

        private bool isSearching = false;

        private static HomeForm _instance;
        DatabaseHelper databaseHelper = new DatabaseHelper();
        private string selectedImageUrl = "0";
        private string selectedYoutubeUrl = "0";
        private int selectedRecipeId = 0;
        public HomeForm()
        {
            
            InitializeComponent();
            _instance = this;

            connectToDatabase();

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

            string searchKeyword = tb_search.Text.ToLower();

            if (string.IsNullOrEmpty(searchKeyword))
            {

                listView.Items.Clear();
                filteredRecipesList.Clear();
                PopulateListBox();
                isSearching = false;

            }
            else
            {

                var filteredRecipes = recipes
                    .Where(recipe =>
                        recipe.Name.ToLower().Contains(searchKeyword)
                    )
                    .ToList();
                listView.Items.Clear();

                filteredRecipesList = filteredRecipes;
                isSearching = true;

                foreach (RecipeModelClass recipe in filteredRecipesList)
                {
                    ListViewItem item = new ListViewItem(recipe.ID.ToString());
                    item.SubItems.Add(recipe.Name);
                    item.SubItems.Add(recipe.PreparationTime);
                    item.SubItems.Add(recipe.CreationDate);
                    item.SubItems.Add(recipe.Instructions);

                    listView.Items.Add(item);
                }

            }

        }

        private void btn_open_new_recipes_Click(object sender, EventArgs e)
        {

            string urlToOpen = "https://www.allrecipes.com/recipes/";

            try
            {

                Process.Start(new ProcessStartInfo
                {
                    FileName = urlToOpen,
                    UseShellExecute = true
                });

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_about_Click(object sender, EventArgs e)
        {

            string urlToOpen = "https://www.allrecipes.com/about-us-6648102";

            try
            {

                Process.Start(new ProcessStartInfo
                {
                    FileName = urlToOpen,
                    UseShellExecute = true
                });

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_news_Click(object sender, EventArgs e)
        {

            string urlToOpen = "https://www.allrecipes.com/food-news-trends/";

            try
            {

                Process.Start(new ProcessStartInfo
                {
                    FileName = urlToOpen,
                    UseShellExecute = true
                });

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedIndexCollection selected = listView.SelectedIndices;

            if (listView.SelectedItems.Count > 0)
            {

                if (isSearching)
                {

                    RecipeModelClass t = (RecipeModelClass)filteredRecipesList[selected[0]];

                    ListViewItem selectedListItem = listView.SelectedItems[0];

                    selectedRecipeId = t.ID;
                    selectedImageUrl = t.ImageUrl;
                    selectedYoutubeUrl = t.YoutubeUrl;

                    ShowImageFromUrl(t.ImageUrl);

                    tb_name.Text = t.Name;
                    tb_prep_time.Text = t.PreparationTime;
                    tb_ingredients.Text = t.Ingredients;
                    tb_Instr.Text = t.Instructions;
                    tb_image_url.Text = t.ImageUrl;
                    tb_youtube_url.Text = t.YoutubeUrl;


                    if (selectedListItem.Tag is RecipeModelClass selectedRecipe)
                    {
                        Debug.WriteLine("(selectedListItem.Tag is Recipe selectedRecipe");

                        string imageUrl = selectedRecipe.ImageUrl;

                        // Now, 'imageUrl' contains the ImageUrl of the selected recipe.
                        Debug.WriteLine($"Selected Recipe ImageUrl: {imageUrl}");
                    }
                }

                else
                {

                    RecipeModelClass t = (RecipeModelClass)recipes[selected[0]];

                    ListViewItem selectedListItem = listView.SelectedItems[0];

                    selectedRecipeId = t.ID;
                    selectedImageUrl = t.ImageUrl;
                    selectedYoutubeUrl = t.YoutubeUrl;

                    ShowImageFromUrl(t.ImageUrl);

                    tb_name.Text = t.Name;
                    tb_prep_time.Text = t.PreparationTime;
                    tb_ingredients.Text = t.Ingredients;
                    tb_Instr.Text = t.Instructions;
                    tb_image_url.Text = t.ImageUrl;
                    tb_youtube_url.Text = t.YoutubeUrl;


                    if (selectedListItem.Tag is RecipeModelClass selectedRecipe)
                    {
                        Debug.WriteLine("(selectedListItem.Tag is Recipe selectedRecipe");

                        string imageUrl = selectedRecipe.ImageUrl;

                        // Now, 'imageUrl' contains the ImageUrl of the selected recipe.
                        Debug.WriteLine($"Selected Recipe ImageUrl: {imageUrl}");
                    }
                }


            }
        }

        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_youtube_Click(object sender, EventArgs e)
        {

            string urlToOpen = selectedYoutubeUrl;

            if (urlToOpen != "0")
            {

                try
                {

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = urlToOpen,
                        UseShellExecute = true
                    });

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {

                MessageBox.Show($"You have to select a recipe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            AddRecipe();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            RemoveRecipeById(selectedRecipeId);


        }

        private void pb_recipe_image_Click(object sender, EventArgs e)
        {

            string urlToOpen = selectedImageUrl;

            if (urlToOpen != "0")
            {

                try
                {

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = urlToOpen,
                        UseShellExecute = true
                    });

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                MessageBox.Show($"You have to select a recipe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            UpdateRecipeById(selectedRecipeId);

        }

        private void clearDatas()
        {
            selectedImageUrl = "0";
            selectedRecipeId = 0;
            selectedYoutubeUrl = "0";

            tb_name.Clear();
            tb_prep_time.Clear();
            tb_ingredients.Clear();
            tb_Instr.Clear();
            tb_image_url.Clear();
            tb_youtube_url.Clear();

            pb_recipe_image.Image = Properties.Resources.no_image;
            filteredRecipesList.Clear();
            isSearching = false;
        }

        private void ShowImageFromUrl(string imageUrl)
        {
            try
            {
                WebClient client = new WebClient();
                byte[] imageBytes = client.DownloadData(imageUrl);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pb_recipe_image.Image = Image.FromStream(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /***IDatabaseProcessor***/
        public void connectToDatabase()
        {
            try
            {
                DataTable recipesTable = databaseHelper.fetchRecipeList();

                recipes = new List<RecipeModelClass>();
                DisplayRecipes(recipesTable, recipes);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void DisplayRecipes(DataTable recipesTable, List<RecipeModelClass> recipes)
        {
            try
            {

                //recipes.Clear();

                if (recipesTable.Rows.Count > 0)
                {

                    foreach (DataRow row in recipesTable.Rows)
                    {
                        RecipeModelClass recipe = new RecipeModelClass
                        {
                            ID = Convert.ToInt32(row["id"]),
                            Name = row["name"].ToString(),
                            PreparationTime = row["prepTime"].ToString(),
                            Ingredients = row["ingredients"].ToString(),
                            Instructions = row["instruction"].ToString(),
                            ImageUrl = row["imageUrl"].ToString(),
                            YoutubeUrl = row["youtubeUrl"].ToString(),
                            CreationDate = row["creationDate"].ToString()
                        };

                        recipes.Add(recipe);

                    }

                    _instance.PopulateListBox();

                }
                else
                {
                    Debug.WriteLine("");
                    MessageBox.Show("No recipes found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void UpdateRecipeById(int recipeId)
        {
            if (recipeId == 0)
            {

                MessageBox.Show($"You have to select a recipe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                DialogResult result = MessageBox.Show("Are you sure you want to edit this recipe?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    if (!string.IsNullOrWhiteSpace(tb_name.Text) &&
                    !string.IsNullOrWhiteSpace(tb_prep_time.Text) &&
                    !string.IsNullOrWhiteSpace(tb_ingredients.Text) &&
                    !string.IsNullOrWhiteSpace(tb_Instr.Text) &&
                    !string.IsNullOrWhiteSpace(tb_image_url.Text) &&
                    !string.IsNullOrWhiteSpace(tb_youtube_url.Text))
                    {


                        DateTime currentDate = DateTime.Now;
                        string formattedDate = currentDate.ToString("dd.MM.yyyy");

                        databaseHelper.EditRecipe(recipeId, tb_name.Text, tb_prep_time.Text, tb_ingredients.Text, tb_Instr.Text, tb_image_url.Text, tb_youtube_url.Text, formattedDate);
                        listView.Items.Clear();
                        clearDatas();

                        connectToDatabase();
                        MessageBox.Show($"Changes saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        MessageBox.Show($"Please fill all forms!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
                else
                {

                }
            }
        }



        /***IRecipeDisplay***/

        public void PopulateListBox()
        {

            try
            {

                foreach (RecipeModelClass recipe in recipes)
                {
                    ListViewItem item = new ListViewItem(recipe.ID.ToString());
                    item.SubItems.Add(recipe.Name);
                    item.SubItems.Add(recipe.PreparationTime);
                    item.SubItems.Add(recipe.CreationDate);
                    item.SubItems.Add(recipe.Instructions);

                    listView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void AddRecipe()
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(tb_name.Text) &&
                    !string.IsNullOrWhiteSpace(tb_prep_time.Text) &&
                    !string.IsNullOrWhiteSpace(tb_ingredients.Text) &&
                    !string.IsNullOrWhiteSpace(tb_Instr.Text) &&
                    !string.IsNullOrWhiteSpace(tb_image_url.Text) &&
                    !string.IsNullOrWhiteSpace(tb_youtube_url.Text))
                {


                    DateTime currentDate = DateTime.Now;
                    string formattedDate = currentDate.ToString("dd.MM.yyyy");

                    databaseHelper.AddRecipe(tb_name.Text, tb_prep_time.Text, tb_ingredients.Text, tb_Instr.Text, tb_image_url.Text, tb_youtube_url.Text, formattedDate);
                    listView.Items.Clear();
                    clearDatas();

                    connectToDatabase();
                    MessageBox.Show($"New recipe have been added to list!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show($"Please fill all forms!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void RemoveRecipeById(int recipeId)
        {
            if (recipeId == 0)
            {

                MessageBox.Show($"You have to select a recipe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this recipe?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    databaseHelper.RemoveRecipeById(selectedRecipeId);

                    listView.Items.Clear();
                    clearDatas();
                    connectToDatabase();

                    MessageBox.Show($"The recipe have been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                }
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {

            listView.Items.Clear();
            clearDatas();

            connectToDatabase();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}