using System;
using FluentDB.Model;

namespace FluentDB.Fluent;

public class BaseTableConfig
{
    protected BaseTableConfig(TypeDb typeDb, DataBaseSchema dataBaseSchema)
    {
        _typeDb = typeDb;
        _dataBaseSchema = dataBaseSchema;
    }
    
    private readonly TypeDb _typeDb;

    private readonly DataBaseSchema _dataBaseSchema;
    
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