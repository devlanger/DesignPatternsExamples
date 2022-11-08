namespace DesignPatternsExamples.FactoryMethod
{
    public interface ICreator
    {
        IProduct Order(string product);
    }
}
