using System;
using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class AlterTableConfig: BaseTableConfig
{
    #region ctor
    
    public AlterTableConfig(Table table) : base(table)
    {
        
    }
    #endregion

    #region TableConfig

    #region AddColumn

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
                defaultValue: defaultValue?.ToString()
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

    #endregion

    #region ChangeColumn

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
        string newColumnName)
    {
        var column = Table[oldColumnName];
        ChangeColumn(
            oldColumnName: oldColumnName,
            newColumnName: newColumnName,
            columnType: column.ColumnType,
            canNull: column.CanNull,
            defaultValue: column.DefaultValue
            
        );
        return this;
    }
    
    public AlterTableConfig ChangeColumn(
        string oldColumnName,
        Type newColumnType)
    {
        var column = Table[oldColumnName];
        ChangeColumn(
            oldColumnName: oldColumnName,
            newColumnName: oldColumnName,
            columnType: newColumnType,
            canNull: column.CanNull,
            defaultValue: column.DefaultValue
            
        );
        return this;
    }
    
    public AlterTableConfig ChangeColumn(
        string oldColumnName,
        bool canNull)
    {
        var column = Table[oldColumnName];
        ChangeColumn(
            oldColumnName: oldColumnName,
            newColumnName: oldColumnName,
            columnType: column.ColumnType,
            canNull: canNull,
            defaultValue: column.DefaultValue
            
        );
        return this;
    }
    
    public AlterTableConfig ChangeColumn(
        string oldColumnName,
        object defaultValue)
    {
        var column = Table[oldColumnName];
        ChangeColumn(
            oldColumnName: oldColumnName,
            newColumnName: oldColumnName,
            columnType: column.ColumnType,
            canNull: column.CanNull,
            defaultValue: defaultValue
            
        );
        return this;
    }

    #endregion

    #region DropColumn

    public AlterTableConfig DropColumn(
        string columnName)
    {
        Table.DropColumn(Table[columnName]);
        return this;
    }

    #endregion
    
    #endregion
}