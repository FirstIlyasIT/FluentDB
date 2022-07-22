using System;

namespace FluentDB.Model;

public class Column
{
    #region internalFields

    internal string Name { get; private set; }
    
    internal Type ColumnType { get; private set; }
    
    internal bool CanNull { get; private set; }
    
    internal string DefaultValue { get; private set; }

    #endregion

    #region ctor

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

    #endregion

    #region publicMethods

    public void SetNewData(
        string newColumnName, 
        Type newColumnType, 
        bool canNull,
        string defaultValue)
    {
        Name = newColumnName;
        ColumnType = newColumnType;
        CanNull = canNull;
        DefaultValue = defaultValue;
    }

    #endregion
}