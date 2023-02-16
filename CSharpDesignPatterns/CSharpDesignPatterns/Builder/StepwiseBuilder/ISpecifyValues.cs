namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public interface ISpecifyValues
    {
        IBuildQuery Values(params string[] values);
    }
}
