using System;

namespace FluentDB.Model;

public struct Column
{
    public Type ColumnType { get; }
    
    public bool CanNull { get; }
    
    public string DefaultValue { get; }
    
    public string Name { get; }

    public Column(
        string name, 
        Type columnType, 
        bool canNull, 
        string defaultValue)
    {
        Name = name;
        ColumnType = columnType;
        CanNull = canNull;
        DefaultValue = defaultValue;
    }
}