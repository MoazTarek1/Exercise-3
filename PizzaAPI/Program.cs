using PIZZAAPI;
using PizzaOrder.EntityClasses;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
PizzaConfig config = new();

ToppingEntity top = new();
top.Name = "48al";

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => top.Name);

app.MapGet("/menu", async () => {
    return await config.GetMenu();
});

app.MapGet("/toppings", async () => {
    return await config.GetToppings();
});

app.MapPost("/order", async (Order order) => {
    await config.SaveOrder(order);
});

app.Run();
