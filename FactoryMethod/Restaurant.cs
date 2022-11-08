namespace DesignPatternsExamples.FactoryMethod
{
    public abstract class Restaurant : ICreator
    {
        public abstract IProduct Order(string product);

        public NullReferenceException OrderException => new NullReferenceException("Order name isn't in the database.");
    }
}
