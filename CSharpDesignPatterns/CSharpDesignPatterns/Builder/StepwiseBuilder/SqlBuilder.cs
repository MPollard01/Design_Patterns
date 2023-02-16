using System.Text;

namespace CSharpDesignPatterns.Builder.StepwiseBuilder
{
    public class SqlBuilder : ISpecifySelect, ISpecifyInsert
    {
        private StringBuilder sb = new StringBuilder();

        private class Query : ISpecifyFrom, ISpecifyWhere, IBuildQuery, ISpecifyValues
        {
            private readonly StringBuilder sb;
            public Query(StringBuilder sb)
            {
                this.sb = sb;
            }

            public string Build()
            {
                return sb.ToString();
            }

            public ISpecifyWhere From(string table)
            {
                sb.Append($" FROM {table} ");
                return this;
            }

            public IBuildQuery Values(params string[] values)
            {
                sb.Append(" (");
                foreach (var value in values)
                {
                    if(int.TryParse(value, out int val))
                        sb.Append($"{val}, ");
                    else
                        sb.Append($"'{value}', ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append(")");
                return this;
            }

            public IBuildQuery Where(string prop, string value)
            {
                sb.Append($"WHERE {prop} = '{value}'");
                return this;
            }

            public IBuildQuery Where(string prop, int value)
            {
                sb.Append($"WHERE {prop} = {value}");
                return this;
            }
        }

        public ISpecifyFrom Select(params string[] values)
        {
            sb.Clear();
            sb.Append("SELECT ")        
              .AppendJoin(", ", values);
            return new Query(sb);
        }

        public ISpecifyValues Insert(string table, params string[] props)
        {
            sb.Clear();
            sb.Append($"INSERT INTO {table} (")
              .AppendJoin(", ", props)
              .Append(")");
            return new Query(sb);
        }
    }
}
