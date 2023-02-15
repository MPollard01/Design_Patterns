namespace CSharpDesignPatterns.Builder.FunctionalBuilder
{
    public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
        public PersonBuilder Called(string name) => Do(p => p.Name = name);
        public new PersonBuilder Do(Action<Person> action) => AddAction(action);
        public new Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
        private PersonBuilder AddAction(Action<Person> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return this;
        }
    }
}
