namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public interface ISpecifySelect
    {
        ISpecifyFrom Select(params string[] values);
    }
}
