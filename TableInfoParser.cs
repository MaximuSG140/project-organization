using System.Reflection;
using System.Runtime.CompilerServices;

namespace ProjectOrganization;

internal class TableInfoParser<TEntity> where TEntity : class
{
    public static Dictionary<string, Type> PropertiesTypes
    {
        get
        {
            var entityType = typeof(TEntity);
            var properties = entityType.GetProperties();
            Dictionary<string, Type> result = new();
            foreach (var property in properties)
            {
                var type = property.PropertyType;
                result.Add(property.Name, type);
            }

            return result;
        }
    }

    public static Dictionary<string, object> GetPropertiesValues(TEntity entity)
    {
        var type = typeof(TEntity);
        var properties = type.GetProperties();
        return properties.ToDictionary(property => property.Name, property => property.GetValue(entity)!);
    }

    public static PropertyInfo[] Properties
    {
        get
        {
            var entityType = typeof(TEntity);
            return entityType.GetProperties();
        }
    }

    public static void Assign(TEntity source, TEntity destination)
    {
        foreach (var property in Properties)
        {
            var propertyValue = property.GetValue(source)!;
            property.SetValue(destination, propertyValue);
        }
    }

    public static PropertyInfo GetPropertyByName(string name)
    {
        var entityType = typeof(TEntity);
        return entityType.GetProperty(name)!;
    }

    public static void SetProperty(TEntity entity, string name, object value)
    {
        var property = GetPropertyByName(name);
        property.SetValue(entity, value);
    }
}
