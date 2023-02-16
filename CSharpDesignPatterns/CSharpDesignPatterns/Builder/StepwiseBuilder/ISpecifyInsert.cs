namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public interface ISpecifyInsert
    {
        ISpecifyValues Insert(string table, params string[] props);
    }
}
