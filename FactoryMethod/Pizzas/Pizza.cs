namespace DesignPatternsExamples.FactoryMethod
{
    public abstract class Pizza : IProduct
    {
        public abstract string Name { get; }

        public abstract void Prepare();
    }
}
