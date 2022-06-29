using System;
using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.Fluent;

public class BaseTableConfig
{
    protected BaseTableConfig(TypeDb typeDb, Table table)
    {
        _typeDb = typeDb;
        _table = table;
    }
    
    private readonly TypeDb _typeDb;

    private readonly Table _table;
    
    protected Table Table => _table;

    protected string TypeResolve(Type type)
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

    protected string DefaultValueResolve(object defaultValue)
    {
        if(defaultValue is null)
            return "NULL";
        return defaultValue.ToString();
    }
}