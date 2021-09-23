using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using Spectre.Console;
using System.Net.Http;
using System.Net.Http.Json;

namespace OrderPizza
{
    public class Window
    {
        private readonly HttpClient _httpClient;

        public Window(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task RunConsole() 
        {
            var userSelection = DrawMainMenu();
            
            while (userSelection != "Exit")
            {
                List<Pizza> pizzas = new(); 
                (int numberOfPizza, string customerName) = DrawTakingOrder();
                for (int i = 0; i < numberOfPizza; i++)
                {
                    var orderType = DrawCustomOrMenu();
                    if (orderType == "Pizza from menu")
                    {
                        var menu = await _httpClient.GetFromJsonAsync<List<Pizza>>("http://localhost:5000/menu");
                        pizzas.Add(DrawMenuPizzaSelect(menu));
                    }
                    else if (orderType == "Custom made pizza")
                    {
                        var toppings = await _httpClient.GetFromJsonAsync<List<Topping>>("http://localhost:5000/toppings");
                        pizzas.Add(DrawCustomPizzaSelect(toppings));
                    }                    
                }
                Order order = new(customerName, pizzas);
                await _httpClient.PostAsJsonAsync<Order>("http://localhost:5000/order", order);
                userSelection = DrawMainMenu();
            }   
        }

        public string DrawMainMenu()
        {
            AnsiConsole.Clear();
            var userChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Start you order", "Exit"
            }));
            return userChoice;
        }

        public (int, string) DrawTakingOrder()
        {
            AnsiConsole.Clear();
            string customerName = AnsiConsole.Ask<string>("What's your name?");   
            int numberOfPizza = AnsiConsole.Ask<int>("How many pizzas would you like to order?"); 
            return (numberOfPizza, customerName);          
        }
        
        public string DrawCustomOrMenu()
        {
            AnsiConsole.Clear();
            var userChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Pizza from menu or custom pizza?:")
                    .PageSize(10)
                    .AddChoices(new[]{
                        "Pizza from menu",
                        "Custom made pizza"
            }));
            return userChoice;                
        }

        public string DrawSizeSelect()
        {
            AnsiConsole.Clear();
            var pizzaSize = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose a size:")
                    .PageSize(10)
                    .AddChoices(new[] {"Small", "Medium", "Large"}
            ));
            return pizzaSize;  
        }

        public Pizza DrawMenuPizzaSelect(List<Pizza> pizzaMenu)
        {
            AnsiConsole.Clear();
            Pizza selectedPizza = AnsiConsole.Prompt(
                new SelectionPrompt<Pizza>()
                    .Title("Choose a pizza:")
                    .PageSize(10)
                    .AddChoices(pizzaMenu)
            );
            string pizzaSize = this.DrawSizeSelect();
            Pizza pizza = new(selectedPizza.Id, selectedPizza.Name, selectedPizza.Toppings, pizzaSize, false);
            return pizza;     
        }    

        public Pizza DrawCustomPizzaSelect(List<Topping> listOfToppings)
        {
            AnsiConsole.Clear();
            var toppings = AnsiConsole.Prompt(
                new MultiSelectionPrompt<Topping>()
                    .Title("Choose your toppings:")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more toppings)[/]")
                    .InstructionsText(
                        "[grey](Press [blue]<space>[/] to toggle a topping, " + 
                        "[green]<enter>[/] to accept)[/]")
                    .AddChoices(listOfToppings)
            );
            var pizzaName = AnsiConsole.Ask<string>("What do you want to name your pizza?");
            string pizzaSize = this.DrawSizeSelect();
            Pizza pizza = new(0, pizzaName, toppings, pizzaSize, true);
            return pizza;
        } 
    }
}