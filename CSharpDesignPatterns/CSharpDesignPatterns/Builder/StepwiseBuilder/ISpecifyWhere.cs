namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public interface ISpecifyWhere
    {
        IBuildQuery Where(string prop, string value);
        IBuildQuery Where(string prop, int value);
    }
}
