namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType type);
    }
}
