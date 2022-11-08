using DesignPatternsExamples.FactoryMethod.Models;

namespace DesignPatternsExamples.FactoryMethod
{
    public class AmericanRestaurant : Restaurant
    {
        public override Pizza Order(string product)
        {
            Pizza result;
            switch (product)
            {
                case "detroit":
                    result = new DetroitPizza();
                    break;
                case "california":
                    result = new CaliforniaPizza();
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
