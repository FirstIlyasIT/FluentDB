using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class CreateTableConfig : BaseTableConfig
{
    private readonly DataBaseSchema _schema;
    public CreateTableConfig(Table table, DataBaseSchema currentDataBaseSchema) : base(table)
    {
        _schema = currentDataBaseSchema;
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
                columnName: columnName,
                type: typeof(TType),
                autoIncrement: autoIncrement,
                startAutoIncrement: startAutoIncrement.ToString()
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
        Table.AddReference(
            new Reference(
                columnName: columnName,
                referenceTable: _schema[referenceTable],
                referenceColumn: _schema[referenceTable][referenceColumn],
                onUpdate: onUpdate,
                onDelete: onDelete
            )
        );
        return this;
    }
}