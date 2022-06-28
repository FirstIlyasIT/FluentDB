using System;

namespace NHibFluent.Model;

public class NewTableConfig : BaseTableConfig
{
    public NewTableConfig(string tableName)
    {
        Config = "CREATE TABLE IF NOT EXISTS {tableName}";
    }

    public NewTableConfig AddColumn(
        string columnName, 
        bool canNull,
        Type columnType)
    {
        return this;
    }
    
    public NewTableConfig AddColumn<TArrayType>(
        string columnName, 
        bool canNull,
        TArrayType[] columnType)
    {
        return this;
    }

    public NewTableConfig PrimaryKey<TType>(
        string columnName,
        bool autoIncrement,
        TType startAutoIncrement)
    {
        return this;
    }
}