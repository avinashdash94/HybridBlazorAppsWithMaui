

using CoffeeBrowser.Library.Data;
using System.Net.Http.Json;

namespace CoffeeBrowser.Maui.Data;

public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient = new();
    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {
        //Coffee[] coffees = [
        //    new Coffee("Espresso", "A strong and concentrated coffee brewed by forcing hot water through finely-ground coffee beans."),
        //    new Coffee("Latte", "A creamy coffee drink made with espresso and steamed milk, often topped with a light layer of foam."),
        //    new Coffee("Cappuccino", "A rich coffee drink made with equal parts espresso, steamed milk, and frothed milk."),
        //    new Coffee("Americano", "A simple coffee drink made by diluting espresso with hot water, resulting in a milder flavor."),
        //    new Coffee("Mocha", "A chocolate-flavored variant of a latte, combining espresso, steamed milk, and chocolate syrup.")
        //];

        var coffees = await _httpClient.GetFromJsonAsync<IEnumerable<Coffee>>("https://thomasclaudiushuber.com/pluralsight/coffees.json");
        await Task.Delay(1000); // Simulate a delay for loading data
        return coffees;
    }
}
