namespace DesignPatternsExamples.FactoryMethod.Models
{
    public class CaliforniaPizza : Pizza
    {
        public override string Name => "California Pizza";

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Adding california pizza ingredients.");
        }
    }
}
