using System.Collections.Generic;
using DojoCocktail.Impl;
using Xunit;

namespace DojoCocktail.Tests
{
    public class Cocktail_PrepareShould
    {
        private readonly Cocktail _cocktail;
        public Cocktail_PrepareShould()
        {
            _cocktail = new Cocktail();
        }

        [Fact]
        public void ReturnBeer_WhenIngredientIsBeer()
        {
            ICollection<string> ingredients = new[] { Ingredients.Beer };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.Beer, recipe);
        }

        [Fact]
        public void ReturnVodka_WhenIngredientIsVodka()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.Vodka, recipe);
        }

        [Fact]
        public void ReturnSkoll_WhenIngredientIsVodkaAndBeer()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Beer };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.Skoll, recipe);
        }

        [Fact]
        public void ReturnSkollFruit_WhenIngredientIsVodkaAndBeerAndFruit()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Beer, Ingredients.Fruit };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.SkollFruitz, recipe);
        }

        [Fact]
        public void ReturnDesperado_WhenIngredientIsBeerAndTequilla()
        {
            ICollection<string> ingredients = new[] { Ingredients.Beer, Ingredients.Tequila };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.Desperados, recipe);
        }

        [Fact]
        public void ReturnMonaco_WhenIngredientIsBeerAndSodaWaterAndFruit()
        {
            ICollection<string> ingredients = new[] { Ingredients.Beer, Ingredients.Fruit, Ingredients.SodaWater };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.Monaco, recipe);
        }

        [Fact]
        public void ReturnPanache_WhenIngredientIsBeerAndSodaWater()
        {
            ICollection<string> ingredients = new[] { Ingredients.Beer, Ingredients.SodaWater };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.Panache, recipe);
        }

        [Fact]
        public void ReturnBlue_Shark_WhenIngredientIsVodkaAndTequila()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Tequila };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.BlueShark, recipe);
        }

        [Fact]
        public void ReturnTGV_WhenIngredientIsVodkaAndTequilaAndGin()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Tequila, Ingredients.Gin };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.TGV, recipe);
        }

        [Fact]
        public void ReturnLong_Island_WhenIngredientIsVodkaAndTequilaAndGinAndFruit()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Tequila, Ingredients.Gin, Ingredients.Fruit };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.LongIsland, recipe);
        }

        [Fact]
        public void ReturnVodka_Coffins_WhenIngredientIsVodkaAndGin()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Gin };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.VodkaCoffins, recipe);
        }

        [Fact]
        public void ReturnMarine_s_Vodka_WhenIngredientIsVodkaAndFruitAndSodaWater()
        {
            ICollection<string> ingredients = new[] { Ingredients.Vodka, Ingredients.Fruit, Ingredients.SodaWater };

            var recipe = _cocktail.Prepare(ingredients);

            Assert.Equal(Recipes.MarinesVodka, recipe);
        }
    }
}
