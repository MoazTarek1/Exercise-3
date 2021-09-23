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

        public PizzaConfig()
        {
            NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite(geographyAsDefault: true);
            RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(
                                            c => c.SetTraceLevel(System.Diagnostics.TraceLevel.Verbose)
                                                  .AddDbProviderFactory(typeof(NpgsqlFactory)));
        }

        public async Task<List<Topping>> GetToppingsAsync()
        {
            _dataAccessAdapter = new DataAccessAdapter("Server=localhost;Port=5432;Database=Pizza;User Id=postgres;Password=7425584mo;");
            LinqMetaData meteData = new(_dataAccessAdapter);
            var toppingsEntity = await meteData.Topping.ToListAsync();
            var toppings = new List<Topping>();
            for (int i = 0; i < toppingsEntity.Count; i++)
            {
                Topping toppingToAdd = new Topping(toppingsEntity.ElementAt(i).Name, toppingsEntity.ElementAt(i).Price);
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