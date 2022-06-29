using System;
using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.Fluent;

public class AlterTableConfig: BaseTableConfig
{
    public AlterTableConfig(TypeDb typeDb, Table table) : base(typeDb, table)
    {
        
    }
        
    public AlterTableConfig AddColumn<TArrayType>(
        string columnName, 
        TArrayType[] columnType, 
        bool canNull, 
        object defaultValue, 
        string namePreviousColumn)
    {
        return this;
    }
    public AlterTableConfig AddColumn(
        string columnName, 
        Type columnType, 
        bool canNull, 
        object defaultValue, 
        string namePreviousColumn)
    {
        var column = new Column(
            columnName, 
            TypeResolve(columnType), 
            canNull, 
            DefaultValueResolve(defaultValue));
        Table.AddColumn(ref column);
        return this;
    }
        
    public AlterTableConfig ChangeColumn<TArrayType>(
        string oldColumnName, 
        string newColumnName, 
        TArrayType[] columnType, 
        bool canNull)
    {
        return this;
    }
        
    public AlterTableConfig ChangeColumn(
        string oldColumnName, 
        string newColumnName, 
        Type columnType, 
        bool canNull)
    {
        return this;
    }
        
    public AlterTableConfig DropColumn(string columnName)
    {
        return this;
    }
}