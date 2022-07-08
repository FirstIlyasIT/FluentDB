using System;
using FluentDB.Model;

namespace FluentDB.Fluent;

public class AlterTableConfig: BaseTableConfig
{
    public AlterTableConfig(Table table) : base(table)
    {
        
    }
    public AlterTableConfig AddColumn<TType>(
        string columnName,
        bool canNull, 
        TType defaultValue)
    {
        return this;
    }
    
    public AlterTableConfig AddColumn<TType>(
        string columnName,
        bool canNull)
    {
        return AddColumn<TType>(columnName: columnName, canNull: canNull, defaultValue: default);
    }

    public AlterTableConfig ChangeColumn(
        string oldColumnName, 
        string newColumnName, 
        Type columnType, 
        bool canNull)
    {
        return this;
    }
        
    public AlterTableConfig DropColumn(
        string columnName)
    {
        return this;
    }
}