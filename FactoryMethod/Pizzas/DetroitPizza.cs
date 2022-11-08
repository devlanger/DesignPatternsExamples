namespace DesignPatternsExamples.FactoryMethod.Models
{
    public class DetroitPizza : Pizza
    {
        public override string Name => "Detroit Pizza";

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Ingredients for this pizza are out of stock. Buy them!");
        }
    }
}
