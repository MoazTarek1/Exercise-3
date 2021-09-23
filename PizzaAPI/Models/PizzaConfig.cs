using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using PizzaOrder.DatabaseSpecific;
using PizzaOrder.EntityClasses;
using PizzaOrder.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Npgsql;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Threading.Tasks;
using ToppingsOnPizza.DtoClasses;
using ToppingsOnPizza.Persistence;

namespace PIZZAAPI
{
    public enum Size
    {
        Small = 120,
        Medium = 150,
        Large = 175
    }
    public class PizzaConfig
    {
        const string Menu = "Models/Menu.json";
        const string Toppings = "Models/Toppings.json";
        private DataAccessAdapter _dataAccessAdapter;
        const string _connectionString = "Server=localhost;Port=5432;Database=Pizza;User Id=postgres;Password=7425584mo;";

        public PizzaConfig()
        {
            NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite(geographyAsDefault: true);
            RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(
                                            c => c.SetTraceLevel(System.Diagnostics.TraceLevel.Verbose)
                                                  .AddDbProviderFactory(typeof(NpgsqlFactory)));
        }

        public async Task<List<Pizza>> GetMenuAsync()
        {
            _dataAccessAdapter = new DataAccessAdapter(_connectionString);
            LinqMetaData metaData = new(_dataAccessAdapter);
            var pizzasWithToppings = await ToppingsOnPizzaPersistence.ProjectToToppingsOnPizza(metaData.Pizza).ToListAsync();
            List<Pizza> pizzas = new();
            for (int i = 0; i < pizzasWithToppings.Count; i++)
            {
                List<Topping> onPizzaToppings = new();
                foreach (var topping in pizzasWithToppings[i].PizzaToppings)
                {
                    Topping toppingToBeAdded = new(Convert.ToInt32(topping.Topping.Id), topping.Topping.Name, topping.Topping.Price);
                    onPizzaToppings.Add(toppingToBeAdded);
                }
                Pizza pizzaToBeAdded = new(Convert.ToInt32(pizzasWithToppings[i].Id), pizzasWithToppings[i].Name, onPizzaToppings, pizzasWithToppings[i].Size);
                pizzas.Add(pizzaToBeAdded);
            }
            return pizzas;
        }

        public async Task<List<Topping>> GetToppingsAsync()
        {
            _dataAccessAdapter = new DataAccessAdapter(_connectionString);
            LinqMetaData metaData = new(_dataAccessAdapter);
            var toppingsEntity = await metaData.Topping.ToListAsync();
            var toppings = new List<Topping>();
            for (int i = 0; i < toppingsEntity.Count; i++)
            {
                Topping toppingToAdd = new Topping(Convert.ToInt32(toppingsEntity.ElementAt(i).Id), toppingsEntity.ElementAt(i).Name, toppingsEntity.ElementAt(i).Price);
                toppings.Add(toppingToAdd);
            }
            return toppings;
        }

        public async Task SaveOrder(Order order)
        {
            string jsonData = JsonSerializer.Serialize(order, new JsonSerializerOptions { WriteIndented = true });
            if (!Directory.Exists("Orders"))
            {
                Directory.CreateDirectory("Orders");
            }
            if (File.Exists($"Orders/{order.CustomerName}.json"))
            {
                await File.WriteAllTextAsync($"Orders/{order.CustomerName}1.json", jsonData);
            }
            else
            {
                await File.WriteAllTextAsync($"Orders/{order.CustomerName}.json", jsonData);
            }
        }
    }
}