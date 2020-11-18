namespace Patterns.Dapper
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class DapperTableAttribute : Attribute
    {
        private string tableName;

        public DapperTableAttribute(string tableName)
        {
            this.tableName = tableName;
        }

        public string GetTableName => this.tableName;
    }
}
