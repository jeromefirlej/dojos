using System.Collections.Generic;
using System.Collections.Immutable;

namespace DojoCocktail.Impl
{
    public class Recipes
    {
        public const string Beer = "Beer";
        public const string Vodka = "Vodka";
        public const string Skoll = "Skoll";
        public const string SkollFruitz = "SkollFruitz";
        public const string Desperados = "Desperados";
        public const string Monaco = "Monaco";
        public const string Panache = "Panache";
        public const string BlueShark = "Blue Shark";
        public const string TGV = "TGV";
        public const string LongIsland = "Long Island";
        public const string VodkaCoffins = "Vodka Coffins";
        public const string MarinesVodka = "Marine's Vodka";

        public static IImmutableDictionary<string, string> RecipesDictionary = new Dictionary<string, string>                   
        {
            {Ingredients.Beer, Beer},
            {Ingredients.Vodka, Vodka},
            {$"{Ingredients.Beer}{Ingredients.Vodka}", Skoll},
            {$"{Ingredients.Beer}{Ingredients.Fruit}{Ingredients.Vodka}", SkollFruitz},
            {$"{Ingredients.Beer}{Ingredients.Tequila}", Desperados},
            {$"{Ingredients.Beer}{Ingredients.Fruit}{Ingredients.SodaWater}", Monaco},
            {$"{Ingredients.Beer}{Ingredients.SodaWater}", Panache},
            {$"{Ingredients.Tequila}{Ingredients.Vodka}", BlueShark},
            {$"{Ingredients.Gin}{Ingredients.Tequila}{Ingredients.Vodka}", TGV},
            {$"{Ingredients.Fruit}{Ingredients.Gin}{Ingredients.Tequila}{Ingredients.Vodka}", LongIsland},
            {$"{Ingredients.Gin}{Ingredients.Vodka}", VodkaCoffins},
            {$"{Ingredients.Fruit}{Ingredients.SodaWater}{Ingredients.Vodka}", MarinesVodka},
        }.ToImmutableDictionary();
    }
}