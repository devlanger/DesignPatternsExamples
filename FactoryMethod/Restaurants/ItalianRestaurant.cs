using DesignPatternsExamples.FactoryMethod.Models;

namespace DesignPatternsExamples.FactoryMethod
{
    public class ItalianRestaurant : Restaurant
    {
        public override Pizza Order(string product)
        {
            Pizza result;
            switch (product)
            {
                case "pepperoni":
                    result = new PepperoniPizza();
                    break;
                case "prosciutto":
                    result = new ProsciuttoPizza();
                    break;
                default:
                    result = null;
                    Console.WriteLine("Missing item from menu. Can't prepare");
                    break;
            }

            return result;
        }
    }
}
