using Xamarin.Forms;
using System.Linq;
using static Recipies.MainPage;

namespace Recipies
{
    public partial class RecipeDetailsPage : ContentPage
    {
        public RecipeDetailsPage(Recipe selectedRecipe)
        {
            InitializeComponent();

            if (selectedRecipe != null)
            {
                selectedRecipe.IngredientsString = string.Join("\n- ", selectedRecipe.Ingredients.Prepend("-"));
                selectedRecipe.StepsString = string.Join("\n", selectedRecipe.Steps.Select(s => $"Step {s.Key}: {s.Value}"));

                BindingContext = selectedRecipe;
            }
        }      
    }
}
