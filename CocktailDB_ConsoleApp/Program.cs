// See https://aka.ms/new-console-template for more information

using CocktailDB_ConsoleApp;
using CocktailDB_ConsoleApp.Models;

bool running = true;

Console.WriteLine("Hello, Welcome to the Cocktail DB Testing!");
Console.WriteLine("Lets figure out what we want to do and test");

while (running)
{
    try
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("| 1: Search Cocktail By the Name of it        |");
        Console.WriteLine("| 2: Get a random Drink if your filling lucky |");
        Console.WriteLine("| 3: Search by the ingredient                 |");
        Console.WriteLine("| 4: List all cocktails by the first letter   |");
        Console.WriteLine("| 5: Exit the program                         |");
        Console.WriteLine("----------------------------------------------");
        int userSelect = Convert.ToInt32(Console.ReadLine());

        switch (userSelect)
        {
            case 1:
                {
                    #region SearchByName
                    bool SearchByName = true;

                    while (SearchByName)
                    {
                        try
                        {
                            Console.WriteLine("-------------------------------------------------------------------------------------");
                            Console.WriteLine("| You selected to test the end point of the api that searchers a drink by the name!  |");
                            Console.WriteLine("| This will give you a list of drinks that have that name in it                      |");
                            Console.WriteLine("| Whats the name of the cocktail you would like to search for?                       |");
                            Console.WriteLine("-------------------------------------------------------------------------------------");
                            string userSearch = Console.ReadLine();

                            SearchByNameModel.Root response = new SearchByNameModel.Root();
                            try
                            {
                                response = await ApiCalls.SearchByName(userSearch.ToLower());
                                if (response.drinks != null)
                                {
                                    Console.WriteLine("|----------------------------------|");
                                    foreach (var drinks in response.drinks)
                                    {
                                        Console.WriteLine($"| The drink id is {drinks.idDrink}         |");
                                        Console.WriteLine($"| The Drink Name is {drinks.strDrink}      |");
                                        Console.WriteLine($"| The type of drink is {drinks.strCategory}|");
                                        Console.WriteLine($"| This is a {drinks.strAlcoholic} drink    |");
                                        Console.WriteLine("--------------------------------------------");
                                    }

                                    try
                                    {
                                        Console.WriteLine("------------------------------------------------------------------");
                                        Console.WriteLine("| Now lets check out the drink you want to review                 |");
                                        Console.WriteLine("| We are going to use the end point to the api by searching by id |");
                                        Console.WriteLine("| I need you to enter in the drink id you would like to use       |");
                                        Console.WriteLine("------------------------------------------------------------------");
                                        int drinkID = Convert.ToInt32(Console.ReadLine());

                                        DrinkModel.Root drinks = new DrinkModel.Root();
                                        try
                                        {
                                            drinks = await ApiCalls.GetDrinkByID(drinkID);

                                            if (drinks != null)
                                            {
                                                foreach (var drink in drinks.drinks)
                                                {
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine($"| Awsome the drink you looked up is {drink.strDrink} |");
                                                    Console.WriteLine($"| This is an {drink.strAlcoholic} Drink              |");
                                                    Console.WriteLine($"| You will need a {drink.strGlass} for this drink    |");
                                                    Console.WriteLine($"| The instructions are as follows:                   |");
                                                    Console.WriteLine($"| -------------------------------------------------- |");
                                                    Console.WriteLine($"| {drink.strInstructions} |");
                                                    Console.WriteLine($"|----------------------------------------------------|");
                                                    Console.WriteLine($"| Here are the ingredients and mesurements needed to make the drink: |");

                                                    #region ingredients and Measurments
                                                    if (drink.strIngredient1 != null && drink.strMeasure1 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient1} - Measurement: {drink.strMeasure1} |");
                                                    }
                                                    if (drink.strIngredient2 != null && drink.strMeasure2 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient2} - Measurement: {drink.strMeasure2} |");
                                                    }
                                                    if (drink.strIngredient3 != null && drink.strMeasure3 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient3} - Measurement: {drink.strMeasure3} |");
                                                    }
                                                    if (drink.strIngredient4 != null && drink.strMeasure4 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient4} - Measurement: {drink.strMeasure4} |");
                                                    }
                                                    if (drink.strIngredient5 != null && drink.strMeasure5 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient5} - Measurement: {drink.strMeasure5} |");
                                                    }
                                                    if (drink.strIngredient6 != null && drink.strMeasure6 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient6} - Measurement: {drink.strMeasure6} |");
                                                    }
                                                    if (drink.strIngredient7 != null && drink.strMeasure7 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient7} - Measurement: {drink.strMeasure7} |");
                                                    }
                                                    if (drink.strIngredient8 != null && drink.strMeasure8 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient8} - Measurement: {drink.strMeasure8} |");
                                                    }
                                                    if (drink.strIngredient9 != null && drink.strMeasure9 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient9} - Measurement: {drink.strMeasure9} |");
                                                    }
                                                    if (drink.strIngredient10 != null && drink.strMeasure10 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient10} - Measurement: {drink.strMeasure10} |");
                                                    }
                                                    if (drink.strIngredient11 != null && drink.strMeasure11 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient11} - Measurement: {drink.strMeasure11} |");
                                                    }
                                                    if (drink.strIngredient12 != null && drink.strMeasure12 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient12} - Measurement: {drink.strMeasure12} |");
                                                    }
                                                    if (drink.strIngredient13 != null && drink.strMeasure13 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient13} - Measurement: {drink.strMeasure13} |");
                                                    }
                                                    if (drink.strIngredient14 != null && drink.strMeasure14 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient14} - Measurement: {drink.strMeasure14} |");
                                                    }
                                                    if (drink.strIngredient15 != null && drink.strMeasure15 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient15} - Measurement: {drink.strMeasure15} |");
                                                    }
                                                    #endregion
                                                }

                                                try
                                                {
                                                    Console.WriteLine("------------------------------------------");
                                                    Console.WriteLine("| Would you like to search another drink? |");
                                                    Console.WriteLine("| 1: Yes                                  |");
                                                    Console.WriteLine("| 2: No                                   |");
                                                    Console.WriteLine("------------------------------------------");
                                                    int endSearchByDrink = Convert.ToInt32(Console.ReadLine());

                                                    if(endSearchByDrink == 1)
                                                    {
                                                        SearchByName = true;
                                                    }
                                                    else if(endSearchByDrink == 2)
                                                    {
                                                        SearchByName = false;
                                                    }

                                                }
                                                catch 
                                                {
                                                    Console.WriteLine("-------------------------------------------------");
                                                    Console.WriteLine("| Please enter one(1) for yes and two(2) for no. |");
                                                    Console.WriteLine("-------------------------------------------------");
                                                }
                                            

                                            }


                                        }
                                        catch
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine("| Error with the api call;                                      |");
                                            Console.WriteLine("| The api endpoint we tried was the get drink by id api endpoint|");
                                            Console.WriteLine("----------------------------------------------------------------");
                                        }



                                    }



                                    catch
                                    {
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("| Please enter in one of the ids from above |");
                                        Console.WriteLine("--------------------------------------------");
                                    }
                                }
                                else { Console.WriteLine("Lets try that one more time"); }
                            }
                            catch
                            {
                                Console.WriteLine("---------------------------------------------------------------");
                                Console.WriteLine("| Error with the api call;                                     |");
                                Console.WriteLine("| The api endpoint we tried was the search by name api endpoint|");
                                Console.WriteLine("---------------------------------------------------------------");
                            }

                        }
                        catch
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("| Enter in a vailid response  |");
                            Console.WriteLine("------------------------------");
                        }
                    }
                    #endregion
                    break;
                }
            case 2:
                {
                    #region GetRandomDrink
                    bool randomDrink = true;
                    while(randomDrink)
                    {
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("| Sweet you selected to get a random drink! you must be filling ballsy |");
                        Console.WriteLine("| HMMM give me a moment to find you one                                |");
                        Thread.Sleep(1000);
                        Console.WriteLine("| ...                                                                  |");
                        Thread.Sleep(1000);
                        Console.WriteLine("| ......                                                               |");
                        Thread.Sleep(1000);
                        Console.WriteLine("| ........................                                             |");
                        Thread.Sleep(1000);
                        Console.WriteLine("| Hey found one!                                                       |");
                        Thread.Sleep(1000);
                        Console.WriteLine("-----------------------------------------------------------------------");

                        DrinkModel.Root drinks = new DrinkModel.Root();
                        drinks = await ApiCalls.GetARandomDrink();
                        if (drinks != null)
                        {
                            foreach (var drink in drinks.drinks)
                            {
                                Console.WriteLine("------------------------------------------------------");
                                Console.WriteLine($"| The drink is called {drink.strDrink}, try it if you dare |");
                                Console.WriteLine($"| This is an {drink.strAlcoholic} Drink                    |");
                                Console.WriteLine($"| You will need a {drink.strGlass} for this drink          |");
                                Console.WriteLine($"| The instructions are as follows:                         |");
                                Console.WriteLine($"| --------------------------------------------------|");
                                Console.WriteLine($"| {drink.strInstructions} |");
                                Console.WriteLine($"|----------------------------------------------------|");
                                Console.WriteLine($"| Here are the ingredients and mesurements needed to make the drink: |");

                                #region ingredients and Measurments
                                if (drink.strIngredient1 != null && drink.strMeasure1 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient1} - Measurement: {drink.strMeasure1} |");
                                }
                                if (drink.strIngredient2 != null && drink.strMeasure2 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient2} - Measurement: {drink.strMeasure2} |");
                                }
                                if (drink.strIngredient3 != null && drink.strMeasure3 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient3} - Measurement: {drink.strMeasure3} |");
                                }
                                if (drink.strIngredient4 != null && drink.strMeasure4 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient4} - Measurement: {drink.strMeasure4} |");
                                }
                                if (drink.strIngredient5 != null && drink.strMeasure5 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient5} - Measurement: {drink.strMeasure5} |");
                                }
                                if (drink.strIngredient6 != null && drink.strMeasure6 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient6} - Measurement: {drink.strMeasure6} |");
                                }
                                if (drink.strIngredient7 != null && drink.strMeasure7 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient7} - Measurement: {drink.strMeasure7} |");
                                }
                                if (drink.strIngredient8 != null && drink.strMeasure8 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient8} - Measurement: {drink.strMeasure8} |");
                                }
                                if (drink.strIngredient9 != null && drink.strMeasure9 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient9} - Measurement: {drink.strMeasure9} |");
                                }
                                if (drink.strIngredient10 != null && drink.strMeasure10 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient10} - Measurement: {drink.strMeasure10} |");
                                }
                                if (drink.strIngredient11 != null && drink.strMeasure11 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient11} - Measurement: {drink.strMeasure11} |");
                                }
                                if (drink.strIngredient12 != null && drink.strMeasure12 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient12} - Measurement: {drink.strMeasure12} |");
                                }
                                if (drink.strIngredient13 != null && drink.strMeasure13 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient13} - Measurement: {drink.strMeasure13} |");
                                }
                                if (drink.strIngredient14 != null && drink.strMeasure14 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient14} - Measurement: {drink.strMeasure14} |");
                                }
                                if (drink.strIngredient15 != null && drink.strMeasure15 != null)
                                {
                                    Console.WriteLine($"| Ingredient: {drink.strIngredient15} - Measurement: {drink.strMeasure15} |");
                                }
                                #endregion
                            }

                            try
                            {
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("| Want to get another one? |");
                                Console.WriteLine("| 1: Yes                                  |");
                                Console.WriteLine("| 2: No                                   |");
                                Console.WriteLine("------------------------------------------");
                                int endRandomDrink = Convert.ToInt32(Console.ReadLine());

                                if (endRandomDrink == 1)
                                {
                                    randomDrink = true;
                                }
                                else if (endRandomDrink == 2)
                                {
                                    randomDrink = false;
                                }

                            }
                            catch
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("| Please enter one(1) for yes and two(2) for no. |");
                                Console.WriteLine("-------------------------------------------------");
                            }


                        }


                    }
                
                    #endregion
                    break;
                }
            case 3:
                {
                    #region ListByIngredient
                    bool listByIngredient = true;
                    while (listByIngredient)
                    {
                        try
                        {
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("| Sweet you selected to search diffrent drinks based on the ingredients |");
                            Console.WriteLine("| What is the ingredient you would like to use?                         |");
                            Console.WriteLine("------------------------------------------------------------------------");
                            string searchText = Console.ReadLine();

                            ListByIngredientModel.Root drinks = new ListByIngredientModel.Root();
                            try
                            { 
                                drinks = await ApiCalls.GetListByIngredient(searchText.ToLower());
                                
                                if(drinks.drinks != null && drinks.drinks.Count > 0)
                                {
                                    foreach (var drink in drinks.drinks)
                                    {
                                        Console.WriteLine($"| The drink id is {drink.idDrink}         |");
                                        Console.WriteLine($"| The Drink Name is {drink.strDrink}      |");
                                        Console.WriteLine($"| The type of drink is {drink.strCategory}|");
                                        Console.WriteLine($"| This is a {drink.strAlcoholic} drink    |");
                                        Console.WriteLine("--------------------------------------------");
                                    }
                                    try
                                    {
                                        Console.WriteLine("------------------------------------------------------------------");
                                        Console.WriteLine("| Now lets check out the drink you want to review                 |");
                                        Console.WriteLine("| We are going to use the end point to the api by searching by id |");
                                        Console.WriteLine("| I need you to enter in the drink id you would like to use       |");
                                        Console.WriteLine("------------------------------------------------------------------");
                                        int drinkID = Convert.ToInt32(Console.ReadLine());

                                        DrinkModel.Root drinkList = new DrinkModel.Root();
                                        try
                                        {
                                            drinkList = await ApiCalls.GetDrinkByID(drinkID);

                                            if (drinks != null)
                                            {
                                                foreach (var drink in drinkList.drinks)
                                                {
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine($"| Awsome the drink you looked up is {drink.strDrink} |");
                                                    Console.WriteLine($"| This is an {drink.strAlcoholic} Drink              |");
                                                    Console.WriteLine($"| You will need a {drink.strGlass} for this drink    |");
                                                    Console.WriteLine($"| The instructions are as follows:                   |");
                                                    Console.WriteLine($"| -------------------------------------------------- |");
                                                    Console.WriteLine($"| {drink.strInstructions} |");
                                                    Console.WriteLine($"|----------------------------------------------------|");
                                                    Console.WriteLine($"| Here are the ingredients and mesurements needed to make the drink: |");

                                                    #region ingredients and Measurments
                                                    if (drink.strIngredient1 != null && drink.strMeasure1 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient1} - Measurement: {drink.strMeasure1} |");
                                                    }
                                                    if (drink.strIngredient2 != null && drink.strMeasure2 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient2} - Measurement: {drink.strMeasure2} |");
                                                    }
                                                    if (drink.strIngredient3 != null && drink.strMeasure3 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient3} - Measurement: {drink.strMeasure3} |");
                                                    }
                                                    if (drink.strIngredient4 != null && drink.strMeasure4 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient4} - Measurement: {drink.strMeasure4} |");
                                                    }
                                                    if (drink.strIngredient5 != null && drink.strMeasure5 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient5} - Measurement: {drink.strMeasure5} |");
                                                    }
                                                    if (drink.strIngredient6 != null && drink.strMeasure6 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient6} - Measurement: {drink.strMeasure6} |");
                                                    }
                                                    if (drink.strIngredient7 != null && drink.strMeasure7 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient7} - Measurement: {drink.strMeasure7} |");
                                                    }
                                                    if (drink.strIngredient8 != null && drink.strMeasure8 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient8} - Measurement: {drink.strMeasure8} |");
                                                    }
                                                    if (drink.strIngredient9 != null && drink.strMeasure9 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient9} - Measurement: {drink.strMeasure9} |");
                                                    }
                                                    if (drink.strIngredient10 != null && drink.strMeasure10 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient10} - Measurement: {drink.strMeasure10} |");
                                                    }
                                                    if (drink.strIngredient11 != null && drink.strMeasure11 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient11} - Measurement: {drink.strMeasure11} |");
                                                    }
                                                    if (drink.strIngredient12 != null && drink.strMeasure12 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient12} - Measurement: {drink.strMeasure12} |");
                                                    }
                                                    if (drink.strIngredient13 != null && drink.strMeasure13 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient13} - Measurement: {drink.strMeasure13} |");
                                                    }
                                                    if (drink.strIngredient14 != null && drink.strMeasure14 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient14} - Measurement: {drink.strMeasure14} |");
                                                    }
                                                    if (drink.strIngredient15 != null && drink.strMeasure15 != null)
                                                    {
                                                        Console.WriteLine($"| Ingredient: {drink.strIngredient15} - Measurement: {drink.strMeasure15} |");
                                                    }
                                                    #endregion
                                                }

                                                try
                                                {
                                                    Console.WriteLine("------------------------------------------");
                                                    Console.WriteLine("| Would you like to search another drink? |");
                                                    Console.WriteLine("| 1: Yes                                  |");
                                                    Console.WriteLine("| 2: No                                   |");
                                                    Console.WriteLine("------------------------------------------");
                                                    int endSearchByIngredient = Convert.ToInt32(Console.ReadLine());

                                                    if (endSearchByIngredient == 1)
                                                    {
                                                        listByIngredient = true;
                                                    }
                                                    else if (endSearchByIngredient == 2)
                                                    {
                                                        listByIngredient = false;
                                                    }

                                                }
                                                catch
                                                {
                                                    Console.WriteLine("-------------------------------------------------");
                                                    Console.WriteLine("| Please enter one(1) for yes and two(2) for no. |");
                                                    Console.WriteLine("-------------------------------------------------");
                                                }


                                            }


                                        }
                                        catch
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine("| Error with the api call;                                      |");
                                            Console.WriteLine("| The api endpoint we tried was the get drink by id api endpoint|");
                                            Console.WriteLine("----------------------------------------------------------------");
                                        }



                                    }



                                    catch
                                    {
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("| Please enter in one of the ids from above |");
                                        Console.WriteLine("--------------------------------------------");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("That did not work try one more time");
                                }
                          


                            }
                            catch
                            {
                                Console.WriteLine("------------------------------------------------------------------------------------------------");
                                Console.WriteLine("| There was an issue with the api end point to list the drinks based on the ingredient provided |");
                                Console.WriteLine("------------------------------------------------------------------------------------------------");
                            }
                           



                        }
                        catch
                        {
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("| There was an error in the ingredient you used                         |");
                            Console.WriteLine("| Try that one more time!                                               |");
                            Console.WriteLine("------------------------------------------------------------------------");
                        }
                    }
            

                    #endregion
                    break;
                }
            case 4:
                {
                    #region SearchByLetter
                    bool searchByLetter = true;
                    while (searchByLetter)
                    {
                        try
                        {
                            Console.WriteLine("----------------------------------------------------------------------");
                            Console.WriteLine("| Here we will give you a list of drinks with the letter you provided |");
                            Console.WriteLine("| What is the letter you want to use?                                 |");
                            Console.WriteLine("| Rember one letter only.                                             |");
                            Console.WriteLine("----------------------------------------------------------------------");
                            string searchText = Console.ReadLine();
                            if(searchText.Length > 1)
                            {
                                Console.WriteLine("Well you did not do that right, its not hard.... only one letter");
                            }
                            else
                            {
                                SearchByLetter.Root drinks = new SearchByLetter.Root();
                                drinks = await ApiCalls.GetDrinksByLetter(searchText);

                                foreach (var drink in drinks.drinks)
                                {
                                    Console.WriteLine($"| The drink id is {drink.idDrink}         |");
                                    Console.WriteLine($"| The Drink Name is {drink.strDrink}      |");
                                    Console.WriteLine($"| The type of drink is {drink.strCategory}|");
                                    Console.WriteLine($"| This is a {drink.strAlcoholic} drink    |");
                                    Console.WriteLine("--------------------------------------------");
                                }

                                try
                                {
                                    Console.WriteLine("------------------------------------------------------------------");
                                    Console.WriteLine("| Now lets check out the drink you want to review                 |");
                                    Console.WriteLine("| We are going to use the end point to the api by searching by id |");
                                    Console.WriteLine("| I need you to enter in the drink id you would like to use       |");
                                    Console.WriteLine("------------------------------------------------------------------");
                                    int drinkID = Convert.ToInt32(Console.ReadLine());

                                    DrinkModel.Root drinkList = new DrinkModel.Root();
                                    try
                                    {
                                        drinkList = await ApiCalls.GetDrinkByID(drinkID);

                                        if (drinks != null)
                                        {
                                            foreach (var drink in drinkList.drinks)
                                            {
                                                Console.WriteLine("------------------------------------------------------");
                                                Console.WriteLine($"| Awsome the drink you looked up is {drink.strDrink} |");
                                                Console.WriteLine($"| This is an {drink.strAlcoholic} Drink              |");
                                                Console.WriteLine($"| You will need a {drink.strGlass} for this drink    |");
                                                Console.WriteLine($"| The instructions are as follows:                   |");
                                                Console.WriteLine($"| -------------------------------------------------- |");
                                                Console.WriteLine($"| {drink.strInstructions} |");
                                                Console.WriteLine($"|----------------------------------------------------|");
                                                Console.WriteLine($"| Here are the ingredients and mesurements needed to make the drink: |");

                                                #region ingredients and Measurments
                                                if (drink.strIngredient1 != null && drink.strMeasure1 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient1} - Measurement: {drink.strMeasure1} |");
                                                }
                                                if (drink.strIngredient2 != null && drink.strMeasure2 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient2} - Measurement: {drink.strMeasure2} |");
                                                }
                                                if (drink.strIngredient3 != null && drink.strMeasure3 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient3} - Measurement: {drink.strMeasure3} |");
                                                }
                                                if (drink.strIngredient4 != null && drink.strMeasure4 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient4} - Measurement: {drink.strMeasure4} |");
                                                }
                                                if (drink.strIngredient5 != null && drink.strMeasure5 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient5} - Measurement: {drink.strMeasure5} |");
                                                }
                                                if (drink.strIngredient6 != null && drink.strMeasure6 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient6} - Measurement: {drink.strMeasure6} |");
                                                }
                                                if (drink.strIngredient7 != null && drink.strMeasure7 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient7} - Measurement: {drink.strMeasure7} |");
                                                }
                                                if (drink.strIngredient8 != null && drink.strMeasure8 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient8} - Measurement: {drink.strMeasure8} |");
                                                }
                                                if (drink.strIngredient9 != null && drink.strMeasure9 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient9} - Measurement: {drink.strMeasure9} |");
                                                }
                                                if (drink.strIngredient10 != null && drink.strMeasure10 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient10} - Measurement: {drink.strMeasure10} |");
                                                }
                                                if (drink.strIngredient11 != null && drink.strMeasure11 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient11} - Measurement: {drink.strMeasure11} |");
                                                }
                                                if (drink.strIngredient12 != null && drink.strMeasure12 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient12} - Measurement: {drink.strMeasure12} |");
                                                }
                                                if (drink.strIngredient13 != null && drink.strMeasure13 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient13} - Measurement: {drink.strMeasure13} |");
                                                }
                                                if (drink.strIngredient14 != null && drink.strMeasure14 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient14} - Measurement: {drink.strMeasure14} |");
                                                }
                                                if (drink.strIngredient15 != null && drink.strMeasure15 != null)
                                                {
                                                    Console.WriteLine($"| Ingredient: {drink.strIngredient15} - Measurement: {drink.strMeasure15} |");
                                                }
                                                #endregion
                                            }

                                            try
                                            {
                                                Console.WriteLine("----------------------------------------------------");
                                                Console.WriteLine("| Would you like to search using a diffrent letter? |");
                                                Console.WriteLine("| 1: Yes                                            |");
                                                Console.WriteLine("| 2: No                                             |");
                                                Console.WriteLine("----------------------------------------------------");
                                                int endSearchByLetter = Convert.ToInt32(Console.ReadLine());

                                                if (endSearchByLetter == 1)
                                                {
                                                    searchByLetter = true;
                                                }
                                                else if (endSearchByLetter == 2)
                                                {
                                                    searchByLetter = false;
                                                } 

                                            }
                                            catch
                                            {
                                                Console.WriteLine("-------------------------------------------------");
                                                Console.WriteLine("| Please enter one(1) for yes and two(2) for no. |");
                                                Console.WriteLine("-------------------------------------------------");
                                            }


                                        }


                                    }
                                    catch
                                    {
                                        Console.WriteLine("----------------------------------------------------------------");
                                        Console.WriteLine("| Error with the api call;                                      |");
                                        Console.WriteLine("| The api endpoint we tried was the get drink by id api endpoint|");
                                        Console.WriteLine("----------------------------------------------------------------");
                                    }



                                }



                                catch
                                {
                                    Console.WriteLine("-------------------------------------------");
                                    Console.WriteLine("| Please enter in one of the ids from above |");
                                    Console.WriteLine("--------------------------------------------");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                            Console.WriteLine("| Well something went wrong remeber it should only be one letter Try one more time |");
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                        }
                    }


                    #endregion
                    break;
                }
            case 5:
                
                {
                    Console.WriteLine("Thank you for the testing of the cocktail DB Api");
                    running = false;
                    break;
                }
        }
    }
    catch
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("| Enter the Number for your selection |");
        Console.WriteLine("-------------------------------------");
    }
}


