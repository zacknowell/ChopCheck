namespace Patterns.Dapper
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class DapperColumnAttribute : Attribute
    {
        private string columnName;

        private Type dataType;

        public DapperColumnAttribute (string columnName, Type dataType)
        {
            this.columnName = columnName;
            this.dataType = dataType;
        }

        public bool Identity = false;
    }
}
