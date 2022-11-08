using DesignPatternsExamples.FactoryMethod;
using DesignPatternsExamples.Shared;

namespace DesignPatternsExamples
{
    public class Application
    {
        public void Run()
        {
            //Factory Method
            IDesignPattern factoryMethodImplementation = new FactoryMethodImplementation();
            factoryMethodImplementation.ExecuteImplementation();
        }
    }
}
