namespace RecipeRover.ModelClasses
{
    public class RecipeModelClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PreparationTime { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string ImageUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string CreationDate { get; set; }

    }
}