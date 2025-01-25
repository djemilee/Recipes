using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using static Recipies.MainPage;

namespace Recipies
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Recipe> Recipes { get; set; }
        public ObservableCollection<Recipe> FRecipes { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Recipes = new ObservableCollection<Recipe>
          
{
    new Recipe
    {
        Id = 1,
        Name = "Cheery Winter Salads",
        Image = "Resources/salad.jpg",
        Description = "A delightful and vibrant medley of fresh greens and colorful vegetables that will brighten even the dreariest winter day. This salad combines the crispness of lettuce, the juicy sweetness of ripe tomatoes, and the refreshing crunch of cucumbers, all tossed together with a drizzle of rich olive oil. Perfect as a light appetizer or a healthy side dish, this salad is sure to bring a burst of flavor and a touch of cheer to your table.",
        Ingredients = new List<string> { "Lettuce", "Tomatoes", "Cucumbers", "Olive Oil" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Wash and chop all vegetables." },
            { 2, "Mix in a large bowl." },
            { 3, "Add olive oil and toss to coat." }
        }
    },
    new Recipe
    {
        Id = 2,
        Name = "Cookie Recipe",
        Image = "Resources/cookies.jpg",
        Description = "Indulge in the heavenly taste of these delicious cookies, perfectly baked to satisfy your sweetest cravings. Each bite offers a soft and chewy texture, complemented by the rich flavors of butter, sugar, and gooey chocolate chips. Whether paired with a warm cup of milk or enjoyed as a standalone treat, these cookies are a delightful way to bring comfort and joy to your day. Perfect for sharing with loved ones or savoring all to yourself, they’re guaranteed to make any moment a little sweeter.",
        Ingredients = new List<string> { "Flour", "Sugar", "Butter", "Chocolate Chips" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Preheat oven to 350°F." },
            { 2, "Mix ingredients in a bowl." },
            { 3, "Bake for 15 minutes." }
        }
    },
    new Recipe
    {
        Id = 3,
        Name = "Spaghetti Bolognese",
        Image = "Resources/spaghetti.jpg",
        Description = "Experience the timeless flavors of Italy with this classic Spaghetti Bolognese. Featuring perfectly cooked al dente pasta, smothered in a rich and savory meat sauce made from tender ground beef, ripe tomatoes, and a medley of aromatic herbs and spices. Each bite is a harmonious blend of comforting textures and bold flavors that transport you straight to an Italian trattoria. Perfect for family dinners or special occasions, this hearty dish is a celebration of tradition and taste.",
        Ingredients = new List<string> { "Pasta", "Ground Beef", "Tomato Sauce", "Onions", "Garlic" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Cook pasta according to package instructions." },
            { 2, "Sauté onions and garlic in a pan." },
            { 3, "Add ground beef and cook until browned." },
            { 4, "Pour in tomato sauce and simmer for 20 minutes." }
        }
    },
    new Recipe
    {
        Id = 4,
        Name = "Vegetable Stir Fry",
        Image = "Resources/stirfry.jpg",
        Description = "Savor the vibrant flavors of this healthy and colorful vegetable stir fry, a feast for both the eyes and the palate. Packed with a medley of crisp broccoli, sweet bell peppers, tender carrots, and other fresh vegetables, each bite bursts with natural goodness. Tossed in a savory soy sauce glaze, this dish offers the perfect balance of flavor and nutrition. Quick to prepare and endlessly customizable, it’s an ideal choice for a wholesome weeknight dinner or a light, satisfying meal.",
        Ingredients = new List<string> { "Broccoli", "Carrots", "Bell Peppers", "Soy Sauce" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Chop all vegetables into bite-sized pieces." },
            { 2, "Heat oil in a pan." },
            { 3, "Add vegetables and stir fry for 5-7 minutes." },
            { 4, "Add soy sauce and toss to coat." }
        }
    },
    new Recipe
    {
        Id = 5,
        Name = "Classic Burger",
        Image = "Resources/burger.jpg",
        Description = "Sink your teeth into this juicy and delicious classic burger, a timeless favorite that never goes out of style. Featuring a perfectly seasoned, grilled beef patty nestled between a soft, toasted bun, and topped with crisp lettuce, ripe tomatoes, melted cheese, and a dollop of your favorite condiments. Each bite delivers a mouthwatering combination of flavors and textures that make this burger a crowd-pleaser for any occasion. Whether enjoyed at a backyard barbecue or a casual dinner, this classic delight is sure to satisfy your cravings.",
        Ingredients = new List<string> { "Beef Patty", "Burger Bun", "Lettuce", "Cheese", "Tomato" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Grill the beef patty until fully cooked." },
            { 2, "Assemble the burger with lettuce, cheese, and tomato." },
            { 3, "Serve with fries or chips." }
        }
    },
    new Recipe
    {
        Id = 6,
        Name = "Margherita Pizza",
        Image = "Resources/pizza.jpg",
        Description = "Delight in the simple yet irresistible flavors of this classic Margherita pizza. Featuring a golden, crispy crust topped with a luscious tomato sauce, creamy mozzarella cheese, and fragrant fresh basil leaves, this pizza embodies the essence of Italian cuisine. Every bite offers a perfect harmony of flavors, from the tangy sweetness of the tomatoes to the rich creaminess of the cheese and the herbal freshness of basil. Whether enjoyed as a quick lunch or a centerpiece for a pizza night, this timeless dish is a true crowd-pleaser.",
        Ingredients = new List<string> { "Pizza Dough", "Tomato Sauce", "Mozzarella", "Fresh Basil" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Roll out pizza dough and spread tomato sauce." },
            { 2, "Add mozzarella and fresh basil on top." },
            { 3, "Bake in a preheated oven at 450°F for 10 minutes." }
        }
    },
    new Recipe
    {
        Id = 7,
        Name = "Chicken Caesar Salad",
        Image = "Resources/chickensalad.jpg",
        Description = "Indulge in the hearty goodness of this Chicken Caesar Salad, a perfect blend of flavor and texture. Crisp Romaine lettuce forms the base, complemented by tender, juicy slices of perfectly grilled chicken. Crunchy golden croutons and shavings of rich Parmesan cheese add depth, while a creamy Caesar dressing ties it all together with a tangy, savory finish. Whether enjoyed as a wholesome meal or a satisfying side, this salad is a timeless classic that brings a touch of elegance to any table.",
        Ingredients = new List<string> { "Grilled Chicken", "Romaine Lettuce", "Croutons", "Caesar Dressing", "Parmesan Cheese" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Chop lettuce and add to a large bowl." },
            { 2, "Top with grilled chicken, croutons, and Parmesan cheese." },
            { 3, "Drizzle Caesar dressing and toss to combine." }
        }
    },
    new Recipe
    {
        Id = 8,
        Name = "Pancakes",
        Image = "Resources/pancakes.jpg",
        Description = "Start your day with a stack of these fluffy, golden pancakes that are perfect for breakfast. Light and airy with a melt-in-your-mouth texture, each pancake is a delightful balance of subtle sweetness and buttery goodness. Serve them warm with a drizzle of maple syrup, a pat of butter, or a handful of fresh berries for an indulgent morning treat. Whether enjoyed with family on a lazy weekend or as a quick weekday pick-me-up, these pancakes are the ultimate comfort food to brighten your day.",
        Ingredients = new List<string> { "Flour", "Milk", "Eggs", "Butter", "Maple Syrup" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Mix flour, milk, and eggs to form a batter." },
            { 2, "Cook batter on a hot skillet until golden brown." },
            { 3, "Serve with butter and maple syrup." }
        }
    },
    new Recipe
    {
        Id = 9,
        Name = "French Toast",
        Image = "Resources/frenchtoast.jpg",
        Description = "Treat yourself to the irresistible sweetness of this classic French toast recipe, featuring slices of bread dipped in a rich, creamy mixture of eggs, milk, cinnamon, and sugar. Cooked to golden perfection with a crispy exterior and a soft, custard-like center, each bite is a delightful harmony of textures and flavors. Top it off with powdered sugar, fresh fruits, or a drizzle of maple syrup for an indulgent breakfast or brunch that's sure to impress. This timeless dish is as easy to make as it is delicious to enjoy.",
        Ingredients = new List<string> { "Bread", "Eggs", "Milk", "Cinnamon", "Sugar" },
        Steps = new Dictionary<int, string>
        {
            { 1, "Dip bread slices in a mixture of eggs, milk, cinnamon, and sugar." },
            { 2, "Cook on a skillet until both sides are golden." },
            { 3, "Serve with powdered sugar and syrup." }
        }
    }   
};
            FRecipes = new ObservableCollection<Recipe>();
            foreach (var recipe in Recipes)
            {
                FRecipes.Add(recipe);
            }

            BindingContext = this;
        }
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = e.NewTextValue?.ToLower() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                FRecipes.Clear();
                foreach (var recipe in Recipes)
                {
                    FRecipes.Add(recipe);
                }
            }
            else
            {
                var filtered = Recipes.Where(r =>
                    r.Name.ToLower().Contains(searchText) ||
                    r.Ingredients.Any(i => i.ToLower().Contains(searchText))).ToList();

                FRecipes.Clear();
                foreach (var recipe in filtered)
                {
                    FRecipes.Add(recipe);
                }
            }
        }

        private async void OnRecipeSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;

            var selectedRecipe = e.CurrentSelection[0] as Recipe;

            if (selectedRecipe != null)
            {
                await Navigation.PushAsync(new RecipeDetailsPage(selectedRecipe));
            }

     ((CollectionView)sender).SelectedItem = null; 
        }

        public class Recipe
        {
            public int Id { get; set; } 
            public string Name { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
            public List<string> Ingredients { get; set; }
            public Dictionary<int, string> Steps { get; set; }

            public string IngredientsString { get; set; }
            public string StepsString { get; set; }
        }
    }
}