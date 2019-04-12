using System.Collections.Generic;
using System.Linq;

namespace DojoCocktail.Impl
{
    public class Cocktail
    {
        public string Prepare(ICollection<string> ingredients)
        {
            return Recipes.RecipesDictionary[string.Join("",ingredients.OrderBy(i=> i))];
        }
    }
}
