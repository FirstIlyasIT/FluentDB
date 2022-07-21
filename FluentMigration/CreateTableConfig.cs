using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class CreateTableConfig : BaseTableConfig
{
    public CreateTableConfig(Table table) : base(table)
    {
        
    }

    public CreateTableConfig AddColumn<TType>(
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
    
    public CreateTableConfig AddColumn<TType>(
        string columnName,
        bool canNull)
    {
        return AddColumn<TType>(
            columnName: columnName, 
            canNull: canNull, 
            defaultValue: default
            );
    }

    public CreateTableConfig PrimaryKey<TType>(
        string columnName = "id", 
        bool autoIncrement = true, 
        TType startAutoIncrement = default)
    {
        Table.SetPrimaryKey(
            new PrimaryKey(
                columnName,
                typeof(TType),
                autoIncrement,
                startAutoIncrement
                )
            );
        return this;
    }

    public CreateTableConfig AddReference(
        string columnName, 
        string referenceTable, 
        string referenceColumn, 
        ReferenceOptions onUpdate, 
        ReferenceOptions onDelete)
    {
        return this;
    }
}