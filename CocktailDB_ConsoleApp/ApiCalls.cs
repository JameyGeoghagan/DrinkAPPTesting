using CocktailDB_ConsoleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CocktailDB_ConsoleApp.Models.SearchByNameModel;

namespace CocktailDB_ConsoleApp
{
    public class ApiCalls    
    {
        public ApiCalls(){}    

        //Lets set up the api call for the end point search by the cocktail name
        public static async Task<Root> SearchByName(string name)
        {
            Root myDeserializedClass = new Root();
            HttpClient client = new HttpClient();
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={name}";
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                myDeserializedClass = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
            }

            return myDeserializedClass;
        }

        // Setting up the api end point to get the drink by the drink id
        public static async Task<DrinkModel.Root> GetDrinkByID(int id)
        {
            HttpClient client = new HttpClient();  
            DrinkModel.Root drink = new DrinkModel.Root();
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i={id}";
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                drink = JsonConvert.DeserializeObject<DrinkModel.Root>(await response.Content.ReadAsStringAsync());   
            }
            return drink;            
        }
        // setting up the random drink api call
        public static async Task<DrinkModel.Root> GetARandomDrink()
        {
            HttpClient client = new HttpClient();
            DrinkModel.Root drink = new DrinkModel.Root();
            var url = "https://www.thecocktaildb.com/api/json/v1/1/random.php";
            var response  = await client.GetAsync(url); 
            if (response.IsSuccessStatusCode)
            {
                drink = JsonConvert.DeserializeObject<DrinkModel.Root>(await response.Content.ReadAsStringAsync());
            }

            return drink;
        }

        // setting up the list by inggreadient api call
        public static async Task<ListByIngredientModel.Root> GetListByIngredient(string searchTerm)
        {
            HttpClient client = new HttpClient();
            ListByIngredientModel.Root root = new ListByIngredientModel.Root();
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={searchTerm}";
            var response =await  client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                root = JsonConvert.DeserializeObject<ListByIngredientModel.Root>(await response.Content.ReadAsStringAsync());
            }

            return root;
        }

        //setting up the api call to get a list of drinks by the first letter 
        public static async Task<SearchByLetter.Root> GetDrinksByLetter(string searchTerm)
        {
            HttpClient client = new HttpClient();
            SearchByLetter.Root drinks = new SearchByLetter.Root();
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?f={searchTerm}";
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                drinks = JsonConvert.DeserializeObject<SearchByLetter.Root>(await response.Content.ReadAsStringAsync());    
            }

            return drinks;
        } 
    }
}
