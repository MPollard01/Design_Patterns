using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class CodeBuilder
    {
        private StringBuilder builder = new StringBuilder();

        public int EnsureCapacity(int capacity)
        {
            return builder.EnsureCapacity(capacity);
        }

        public override string ToString()
        {
            return builder.ToString();
        }

        public string ToString(int startIndex, int length)
        {
            return builder.ToString(startIndex, length);
        }

        public CodeBuilder Clear()
        {
            builder.Clear();
            return this;
        }

        public CodeBuilder Append(char value, int repeatCount)
        {
            builder.Append(value, repeatCount);
            return this;
        }

        public CodeBuilder Append(string? value)
        {
            builder.Append(value);
            return this;
        }

        public CodeBuilder AppendLine(string? value)
        {
            builder.Append(value);
            return this;
        }
    }
}
