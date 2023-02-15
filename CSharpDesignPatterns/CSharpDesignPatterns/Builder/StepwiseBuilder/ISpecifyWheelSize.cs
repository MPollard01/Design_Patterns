namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int size);
    }
}
