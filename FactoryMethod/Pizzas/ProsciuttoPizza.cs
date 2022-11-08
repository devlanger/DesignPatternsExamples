namespace DesignPatternsExamples.FactoryMethod.Models
{
    public class ProsciuttoPizza : Pizza
    {
        public override string Name => "Prosciutto Pizza";

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Ham added to the pizza base.");
        }
    }
}
