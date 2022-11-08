using DesignPatternsExamples.Shared;

namespace DesignPatternsExamples.FactoryMethod
{
    public class FactoryMethodImplementation : IDesignPattern
    {
        public void ExecuteImplementation()
        {
            //Open Italian Restaurant
            Console.WriteLine("Open Italian Restaurant");
            ItalianRestaurant italianRestaurant = new ItalianRestaurant();

            //Let the guests order products
            italianRestaurant.Order("pepperoni")?.Prepare();
            italianRestaurant.Order("prosciutto")?.Prepare();

            //Open American Restaurant
            Console.WriteLine("Open American Restaurant");
            AmericanRestaurant americanRestaurant = new AmericanRestaurant();

            //Let the guests order products
            italianRestaurant.Order("pepperoni")?.Prepare();
            italianRestaurant.Order("prosciutto")?.Prepare();

            //The guest orders product missing from the menu
            americanRestaurant.Order("prosciutto")?.Prepare();
        }
    }
}
