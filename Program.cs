using System;

namespace ST10091344_PROG221_POE1
{
    // Define a class to represent a recipe
    class Recipe
    {
        // Define variables to store the recipe data for:

        // Number of Ingredients
        private int ingNum;
        // Name of Ingredients
        private string[] ingName;
        // Quantity of Ingredients
        private double[] ingQuant;
        // Unit of Measurments 
        private string[] ingUnit;
        // Number of Steps
        private int stepNum;
        // Steps Description
        private string[] steps;

        // Define a constructor to initialize the recipe data
        public Recipe()
        {
            ingNum = 0;
            stepNum = 0;
        }

        // Define a method to ask the user to enter the recipe data
        public void EnterRecipeData()
        {
            // Ask the user to enter the number of ingredients
            Console.Write("Enter the number of ingredients: ");
            ingNum = int.Parse(Console.ReadLine());

            // Initialize the arrays to store the ingredient data
            ingName = new string[ingNum];
            ingQuant = new double[ingNum];
            ingUnit = new string[ingNum];

            // Ask the user to enter the details for each ingredient
            for (int i = 0; i < ingNum; i++)
            {
                Console.Write("Enter the name of ingredient " + (i + 1) + ": ");
                ingName[i] = Console.ReadLine();

                Console.Write("Enter the quantity of ingredient " + (i + 1) + ": ");
                ingQuant[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter the unit of measurement for ingredient " + (i + 1) + ": ");
                ingUnit[i] = Console.ReadLine();
            }

            // Ask the user to enter the number of steps
            Console.Write("Enter the number of steps: ");
            stepNum = int.Parse(Console.ReadLine());

            // Initialize the array to store the steps
            steps = new string[stepNum];

            // Ask the user to enter the details for each step
            for (int i = 0; i < stepNum; i++)
            {
                Console.Write("Enter step description: " + (i + 1) + ": ");
                steps[i] = Console.ReadLine();
            }
        }

        // Define a method to display the recipe data
        public void DisplayRecipe()
        {
            // Display the ingredient data
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingNum; i++)
            {
                Console.WriteLine("- " + ingQuant[i] + " " + ingUnit[i] + " " + ingName[i]);
            }

            // Display the step data
            Console.WriteLine("Steps:");
            for (int i = 0; i < stepNum; i++)
            {
                Console.WriteLine((i + 1) + ". " + steps[i]);
            }
        }

        // Define a method to scale the recipe by a given factor
        public void ScaleRecipe(double factor)
        {
            // Scale the ingredient quantities
            for (int i = 0; i < ingNum; i++)
            {
                ingQuant[i] *= factor;
            }
        }

        // Define a method to reset the recipe to the original quantities
        public void ResetRecipe()
        {
            // Reset the ingredient quantities to the original values
            EnterRecipeData();
        }

        // Define a method to clear the recipe data
        public void ClearRecipe()
        {
            // Reset all variables to their initial values
            ingNum = 0;
            ingName = null;
            ingQuant = null;
            ingUnit = null;
            stepNum = 0;
            steps = null;
        }


        // Define the main program class
        class Program
        {
            static void Main(string[] args)
            {
                // Create a new recipe object
                Recipe recipe = new Recipe();

                // Loop until the user chooses to quit
                while (true)
                {
                    // Display the menu options
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Enter Recipe Data");
                    Console.WriteLine("2. Display Recipe");
                    Console.WriteLine("3. Scale Recipe");
                    Console.WriteLine("4. Reset Recipe");
                    Console.WriteLine("5. Clear Recipe");
                    Console.WriteLine("6. Quit");

                    // Ask the user to choose an option
                    Console.Write("Enter Option: ");
                    int option = int.Parse(Console.ReadLine());

                    // Perform the selected action
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

                    // Wait for the user to press a key before continuing
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }
        }
    }
}


