﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10134934_PROG6221_PartOne
{
    public class Recipe
    {

        public void addRecipe(string recipeName, string ingName, double ingQuan, string unitMea, int userIngAmt, int ingNum, ArrayList recipeNameArrayList, ArrayList ingNameArrayList, ArrayList ingQuanArrayList, ArrayList ingUnitArrayList)
        {
            if (recipeNameArrayList.Count != 0)
            {
                Console.WriteLine("Cannot add another recipe until existing recipe is deleted.");
                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Add Recipe selected");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Enter name of recipe");
                recipeName = Console.ReadLine();

                Console.WriteLine("How many Ingredients are in your recipe?");
                while (!int.TryParse(Console.ReadLine(), out userIngAmt))
                {
                    Console.WriteLine("Please enter a valid number of ingredients.");
                }


                for (ingNum = 0; ingNum < userIngAmt; ingNum++)
                {
                    int sum = ingNum + 1;

                    Console.WriteLine("Enter Ingredient" + " " + sum + " " + "Name:");
                    ingName = Console.ReadLine();

                    Console.WriteLine("Enter Quantity of Ingredient:");
                    while (!double.TryParse(Console.ReadLine(), out ingQuan))
                    {
                        Console.WriteLine("Please enter a valid quantity amount.");
                    }

                    Console.WriteLine("Select unit of measurement:");
                    Console.WriteLine("1 - tsp (teaspoon)");
                    Console.WriteLine("2 - tbsp (tablespoon)");
                    Console.WriteLine("3 - C (cup )");
                    Console.WriteLine("4 - ml (milliliter)");
                    Console.WriteLine("5 - L (liter)");
                    Console.WriteLine("6 - g (gram)");
                    Console.WriteLine("7 - Kg (kilogram)");

                    //   unitMea = Console.ReadLine();
                    int UserOp = 0;
                    while (!int.TryParse(Console.ReadLine(), out UserOp))
                    {
                        Console.WriteLine("Please enter a valid unit of measurement.");
                    }

                    switch (UserOp)
                    {

                        case 1:
                            Console.WriteLine("tsp selected");
                            ingUnitArrayList.Add("tsp");

                            break;
                        case 2:
                            Console.WriteLine("tbsp selected");
                            ingUnitArrayList.Add("tbsp");
                            break;
                        case 3:
                            Console.WriteLine("Cup selected");
                            ingUnitArrayList.Add("Cup");
                            break;
                        case 4:
                            Console.WriteLine("ml selected");
                            ingUnitArrayList.Add("ml");
                            break;
                        case 5:
                            Console.WriteLine("L selected");
                            ingUnitArrayList.Add("L");
                            break;
                        case 6:
                            Console.WriteLine("g selected");
                            ingUnitArrayList.Add("g");
                            break;
                        case 7:
                            Console.WriteLine("Kg selected");
                            ingUnitArrayList.Add("Kg");
                            break;
                        default:
                            Console.WriteLine("select a valid unit of measurement");
                            break;
                    }



                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Ingredient entered ");
                    Console.WriteLine("----------------------------------------");


                    recipeNameArrayList.Add(recipeName);
                    ingNameArrayList.Add(ingName);
                    ingQuanArrayList.Add(ingQuan);


                }
            }
        }





    }
}
