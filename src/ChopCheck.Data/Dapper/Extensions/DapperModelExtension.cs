namespace Patterns.Dapper.Extensions
{
    using ChopCheck.Data.Dapper;
    using global::Dapper;

    public static class DapperModelExtension
    {
        public static DynamicParameters GetDynamicParameters(this IDapperModel dapperModel)
        {
            var attributes = dapperModel.GetType().GetCustomAttributes(typeof(DapperTableAttribute), false);
            var dynamicParamaters = new DynamicParameters();

            if (attributes.Length > 0)
            {
                var properties = dapperModel.GetType().GetProperties();

                foreach (var property in properties)
                {
                    var propertyAttributes = property.GetType().GetCustomAttributes(typeof(DapperColumnAttribute), false);
                    var propertyAttributesData = property.GetType().GetCustomAttributesData();

                    if (propertyAttributes.Length > 0)
                    {
                        dynamicParamaters.Add(property.Name, property.GetRawConstantValue(), null, null, null);
                    }
                }
            }

            return dynamicParamaters;
        }
    }
}
