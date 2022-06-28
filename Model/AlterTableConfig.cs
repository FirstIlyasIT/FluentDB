using System;

namespace FluentDB.Model;

public class AlterTableConfig: BaseTableConfig
{
    public AlterTableConfig(string tableName)
    {
        
    }
        
    public AlterTableConfig AddColumn<TArrayType>(string columnName, TArrayType[] columnType, bool canNull, object defaultValue, string namePreviousColumn)
    {
        return this;
    }
    public AlterTableConfig AddColumn(string columnName, Type columnType, bool canNull, object defaultValue, string namePreviousColumn)
    {
        return this;
    }
        
    public AlterTableConfig ChangeColumn<TArrayType>(string oldColumnName, string newColumnName, TArrayType[] columnType, bool canNull)
    {
        return this;
    }
        
    public AlterTableConfig ChangeColumn(string oldColumnName, string newColumnName, Type columnType, bool canNull)
    {
        return this;
    }
        
    public AlterTableConfig DropColumn(string columnName)
    {
        return this;
    }
}