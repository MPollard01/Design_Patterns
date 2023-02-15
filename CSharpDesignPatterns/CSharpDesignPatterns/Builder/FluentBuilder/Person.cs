namespace CSharpDesignPatterns.Builder.FluentBuilder
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        public static Builder New => new Builder();

        public class Builder : PersonJobBuilder<Builder>
        {

        }
    }
}
