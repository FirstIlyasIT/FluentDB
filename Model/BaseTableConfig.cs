using System;

namespace FluentDB.Model;

public class BaseTableConfig
{
    public BaseTableConfig(TypeDb typeDb)
    {
        _typeDb = typeDb;
    }
    
    private TypeDb _typeDb;
    
    private string TypeResolve(Type type)
    {
        if (type == typeof(int))
            return _typeDb switch
            {
                TypeDb.SqlLite => "INTEGER",
                _ => throw new ArgumentOutOfRangeException($"{type} not support")
            };
        
        if (type == typeof(string))
            return _typeDb switch
            {
                TypeDb.SqlLite => "TEXT",
                _ => throw new ArgumentOutOfRangeException($"{type} not support")
            };
        
        if (type == typeof(float) || type == typeof(decimal))
            return _typeDb switch
            {
                TypeDb.SqlLite => "REAL",
                _ => throw new ArgumentOutOfRangeException($"{type} not support")
            };

        throw new ArgumentOutOfRangeException($"{type} not support");
    }
}