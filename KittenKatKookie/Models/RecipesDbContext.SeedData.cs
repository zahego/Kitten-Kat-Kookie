using System;
using System.Collections.Generic;
using System.Linq;

namespace KittenKatKookie.Models
{
    public static class RecipesDbContextSeedData
    {
        static object synchlock = new object();
        static volatile bool seeded = false;

        public static void EnsureSeedData(this RecipesDbContext context)
        {
            if (!seeded && context.Recipes.Count() == 0)
            {
                lock (synchlock)
                {
                    if (!seeded)
                    {
                        var recipes = GenerateRecipes();
                        context.Recipes.AddRange(recipes);
                        context.SaveChanges();
                        seeded = true;
                    }
                }
            }
        }

        public static Recipe[] GenerateRecipes()
        {
            return new Recipe[] {
                new Recipe {
                    Name = "Gateaux",
                    Description = "a rich cake, typically one containing layers of cream or fruit. The pinacle of birthday party.",
                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Directions = string.Join(Environment.NewLine, new List<string> {
                        "Preheat oven to 350 degrees.",
                        "Combine all ingredients in a large mixing bowl until well combined.",
                        "Pour into 6\" x 2\" cake pan.",
                        "Bake for 35 minutes, until meat is thoroughly cooked.",
                        "Cool for 20 minutes.",
                    }),
            SrcImage="./Images/gateau.jpg",
                },
                new Recipe {
                    Name = "Pumpkin Pie",
                    Description = "I thought it would be nice to break away from the traditional cake posts and share one of my favorite desserts to have during the fall. Pumpkin pie! This recipe is adapted from my grandmother’s cookbook.  She would stew her own pumpkin to make her pumpkin pies. My version uses canned pumpkin and lower fat milk, but tastes just as good as hers did growing up.",
                    Directions = string.Join(Environment.NewLine, new List<string> {
                        "Preheat oven to 350 degrees.",
                        "Mix pumpkin with milk, sugar, beaten eggs, ginger, salt, cinnamon, and beat 2 minutes.",
                        "Pour into pastry lined pie tin.",
                        "Place in oven for fifteen minutes.",
                        "Reduce heat to 300 degrees and bake 45 minutes.",
                        "Cool for 45 minutes before serving. Once cool, keep refrigerated.",
                        "Serve with whipped cream, if desired.",
                    }),
                    Ingredients = string.Join(Environment.NewLine, new List<string>
                    {
                        "2 cups canned pumpkin",
                        "2 cups 2% milk",
                        "3/4 cup brown or granulated sugar",
                        "2 eggs",
                        "1/4 Tsp. ginger",
                        "1/2 Tsp. salt",
                        "1 Tsp. cinnamon",
                        "Optional: whipped cream",
                    }),
		    SrcImage="./Images/pumpkin-pie.jpg",
                },
                new Recipe {
                    Name = "Victorian Sponge Cake",
                    Description = "This classic sponge cake is easy to make, but has a sophisticated taste. The raspberries and fresh whipped cream keep it light, but rich at the same time.",
                    Ingredients = string.Join(Environment.NewLine, new List<string>
                    {
                        "Sponge Cake:",
                        "1 cup sugar",
                        "1/2 cup butter",
                        "3 eggs",
                        "1 cup flour, sifted",
                        "1 tsp. lemon extract",
                        "1 tbsp. baking powder",
                        "1/4 tsp. salt",
                        "Raspberry Filling:",
                        "1/2 cup sugar",
                        "1 cup raspberries",
                        "Topping:",
                        "1 cup heavy cream",
                        "1/4 cup sugar",
                        "1 tsp. vanilla extract",
                    }),
                    Directions = string.Join(Environment.NewLine, new List<string>
                    {
                        "Preheat oven to 375 degrees. Line the bottom of an 8-inch spring form pan with parchment paper.",
                        "In a large bowl, whisk eggs and sugar on high speed, until the mixture becomes thick and airy.",
                        "Add butter and lemon extract to the mixture and mix at medium speed until all the ingredients are incorporated.",
                        "Add flour, baking powder, and salt to mixture and blend until smooth.",
                        "Pour into spring form pan and bake for 30 minutes. The sides of the cake should pull away from the pan slightly.",
                        "Remove from oven and allow the cake to cool on a wire rack for 15 minutes.",
                        "While the cake is baking, add raspberries and sugar in a saucepan over medium heat, stirring occasionally.",
                        "When sauce begins to bubble, stir constantly for 2 minutes. Remove from heat and allow to cool.",
                        "For the whipped topping add heavy cream, sugar, and vanilla extract to a chilled bowl. Beat on high speed until stiff peaks form.",
                        "To assemble your Victorian sponge cake, carefully slice the cake in half. Each layer should be about 2 inches thick.",
                        "Spread the raspberry filling on the bottom layer of the cake and ½ of the topping on the bottom of the top layer.",
                        "Sandwich both sides together and spread the remaining topping on the top of the cake.",
                    }),
		    SrcImage="./Images/macca.jpg",
                },
            };
        }
    }
}

