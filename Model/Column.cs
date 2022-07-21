using System;

namespace FluentDB.Model;

public class Column
{
    internal Type ColumnType { get; }
    
    internal bool CanNull { get; }
    
    internal string DefaultValue { get; }
    
    internal string Name { get; }

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