namespace DesignPatternsExamples.FactoryMethod.Models
{
    public class PepperoniPizza : Pizza
    {
        public override string Name => "Pepperoni Pizza";

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Pepperoni added to the pizza base.");
        }
    }
}
