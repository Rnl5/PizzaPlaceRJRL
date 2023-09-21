namespace PizzaPlaceRJRL.Shared;

public class Menu
{
    public List<Pizzas> Pizzas {get; set;} = new List<Pizzas>();

    public void Agregar(Pizzas pizzas) => Pizzas.Add(pizzas);

    public Pizzas? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
}