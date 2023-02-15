using CSharpDesignPatterns.Builder;
using CSharpDesignPatterns.Builder.FluentBuilder;
using CSharpDesignPatterns.Builder.StepwiseBuilder;
using CSharpDesignPatterns.Builder.FunctionalBuilder;
using CSharpDesignPatterns.Decorator;
using PersonBuilder = CSharpDesignPatterns.Builder.FunctionalBuilder.PersonBuilder;
using Person = CSharpDesignPatterns.Builder.FluentBuilder.Person;
using CSharpDesignPatterns.Builder.FacetedBuilder;
using CSharpDesignPatterns.Factory.FactoryMethod;

namespace CSharpDesignPatterns
{
    public class Demo
    {
        static void Main(string[] args)
        {
            // decorator
            Console.WriteLine("decorator");
            var cb = new CodeBuilder();

            cb.AppendLine("class Foo")
                .AppendLine("{")
                .AppendLine("}");

            Console.WriteLine(cb);
            Console.WriteLine();

            // builder
            Console.WriteLine("buidler");
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello")
                   .AddChild("li", "world");
            Console.WriteLine(builder);
            Console.WriteLine();

            // fluent builder inhereitance with recursive generics
            var person = Person.New
                .Called("Mark")
                .WorksAsA("programmer")
                .Build();
            Console.WriteLine(person);
            Console.WriteLine();

            // stepwise builder
            var car = CarBuilder.Create()
                .OfType(CarType.Crossover)
                .WithWheels(18)
                .Build();

            Console.WriteLine(car);
            Console.WriteLine();

            // functional builder
            var pb = new PersonBuilder();
            var john = pb
                .Called("John")
                .WorksAs("Builder")
                .Build();

            Console.WriteLine(john);
            Console.WriteLine();

            // faceted builder
            var eb = new EmployeeBuilder();
            Employee employee = eb
                .Lives.At("123 Street")
                      .In("London")
                      .WithPostcode("SJW 22F")
                .Works.At("Sparta Global")
                      .AsA("C# Developer")
                      .Earning(1000000);

            Console.WriteLine(employee);
            Console.WriteLine();

            // factory method
            var point = Point.NewCartesianPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
            Console.WriteLine();


        }
    }
}