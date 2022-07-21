using System;
using FluentDB.Model;

namespace FluentDB.FluentMigration;

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
        Table.AddColumn(
            new Column(
                name: columnName, 
                columnType:typeof(TType), 
                canNull: canNull, 
                defaultValue: defaultValue.ToString()
                )
            );
        return this;
    }
    
    public AlterTableConfig AddColumn<TType>(
        string columnName,
        bool canNull)
    {
        return AddColumn<TType>(
            columnName: columnName, 
            canNull: canNull, 
            defaultValue: default
            );
    }

    public AlterTableConfig ChangeColumn(
        string oldColumnName, 
        string newColumnName, 
        Type columnType, 
        bool canNull,
        object defaultValue)
    {
        Table[oldColumnName].SetNewData(
            newColumnName: newColumnName, 
            newColumnType: columnType, 
            canNull: canNull,
            defaultValue.ToString()
            );
        return this;
    }
    
    public AlterTableConfig ChangeColumn(
        string oldColumnName,
        Type columnType, 
        bool canNull,
        object defaultValue)
    {
        ChangeColumn(
            oldColumnName: oldColumnName,
            newColumnName: oldColumnName,
            columnType: columnType,
            canNull: canNull,
            defaultValue: defaultValue
        );
        return this;
    }
        
    public AlterTableConfig DropColumn(
        string columnName)
    {
        Table.DropColumn(Table[columnName]);
        return this;
    }
}