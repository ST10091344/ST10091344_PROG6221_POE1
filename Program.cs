using System;

namespace ST10091344_PROG221_POE1
{
    class Recipe
    {
       
        private int ingNum;
        private string[] ingName;
        private double[] ingQuant;
        private string[] ingUnit;
        private int stepNum;
        private string[] steps;

        public Recipe()
        {
            ingNum = 0;
            stepNum = 0;
        }

        public void EnterRecipeData()
        {
            Console.Write("Enter the number of ingredients: ");
            ingNum = int.Parse(Console.ReadLine());

            ingName = new string[ingNum];
            ingQuant = new double[ingNum];
            ingUnit = new string[ingNum];

            for (int i = 0; i < ingNum; i++)
            {
                Console.Write("Enter the name of ingredient " + (i + 1) + ": ");
                ingName[i] = Console.ReadLine();

                Console.Write("Enter the quantity of ingredient " + (i + 1) + ": ");
                ingQuant[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter the unit of measurement for ingredient " + (i + 1) + ": ");
                ingUnit[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of steps: ");
            stepNum = int.Parse(Console.ReadLine());

            steps = new string[stepNum];

            for (int i = 0; i < stepNum; i++)
            {
                Console.Write("Enter step description: " + (i + 1) + ": ");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingNum; i++)
            {
                Console.WriteLine("- " + ingQuant[i] + " " + ingUnit[i] + " " + ingName[i]);
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < stepNum; i++)
            {
                Console.WriteLine((i + 1) + ". " + steps[i]);
            }
        }

        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < ingNum; i++)
            {
                ingQuant[i] *= factor;
            }
        }

        public void ResetRecipe()
        {
            EnterRecipeData();
        }

        public void ClearRecipe()
        {
            ingNum = 0;
            ingName = null;
            ingQuant = null;
            ingUnit = null;
            stepNum = 0;
            steps = null;
        }


        class Program
        {
            static void Main(string[] args)
            {
                Recipe recipe = new Recipe();

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter Recipe Data");
                    Console.WriteLine("2. Display Recipe");
                    Console.WriteLine("3. Scale Recipe");
                    Console.WriteLine("4. Reset Recipe");
                    Console.WriteLine("5. Clear Recipe");
                    Console.WriteLine("6. Quit");

                    Console.Write("Enter Option: ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            recipe.EnterRecipeData();
                            break;
                        case 2:
                            recipe.DisplayRecipe();
                            break;
                        case 3:
                            Console.Write("Enter scaling factor: ");
                            double factor = double.Parse(Console.ReadLine());
                            recipe.ScaleRecipe(factor);
                            break;
                        case 4:
                            recipe.ResetRecipe();
                            break;
                        case 5:
                            recipe.ClearRecipe();
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Invalid Option.");
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }
        }
    }
}


