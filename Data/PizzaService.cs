namespace BlazingPizza.Data;

public class PizzaService
{
	public async Task<Pizza[]> GetPizzasAsync()
	{
		// Call your data access technology here

		var pizzas = new List<Pizza>() {
		new Pizza() { PizzaId=1, Name="Veggie", Description="Nice healthy", Price=10, Vegan=false, Vegetarian=true}
		};
		 return await Task.FromResult( pizzas.ToArray());
	}
}