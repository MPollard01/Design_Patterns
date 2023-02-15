namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public class Car
    {
        public CarType Type { get; set; }
        public int WheelSize { get; set; }

        public override string ToString()
        {
            return $"Brand: {Type}, Number of wheels: {WheelSize}";
        }
    }
}
