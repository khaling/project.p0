
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;


namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        protected override void AddCrust()
        {
            Crust = new Crusts().Name;
        }
        protected override void AddSize()
        {
            Size = new Sizes().Name;
        }

        protected override void AddPrice()
        {
            Price = new Prices().Price;
        }
        
        protected override void AddTopping()
        {   
            Topping = new Toppings().Name;
        }
    }
}