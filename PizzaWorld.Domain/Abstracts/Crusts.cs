using System.ComponentModel.DataAnnotations;

namespace PizzaWorld.Domain.Abstracts
{
    public class Crusts : AEntity
    {
        public string Name { get; set; }
    }
}