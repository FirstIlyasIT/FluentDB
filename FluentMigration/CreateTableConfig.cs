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
    
    public CreateTableConfig AddColumn(
        string columnName,
        bool canNull)
    {
        return AddColumn<string>(
            columnName: columnName, 
            canNull: canNull
            );
    }
    
    public CreateTableConfig AddColumn(
        string columnName,
        bool canNull,
        string defaultValue)
    {
        return AddColumn<string>(
            columnName: columnName, 
            canNull: canNull,
            defaultValue: defaultValue
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
    
    public CreateTableConfig AddReference(
        string columnName, 
        string referenceTable,
        ReferenceOptions onUpdate, 
        ReferenceOptions onDelete)
    {
        Table.AddReference(
            new Reference(
                columnName: columnName,
                referenceTable: _schema[referenceTable],
                referenceColumn: _schema[referenceTable]["id"],
                onUpdate: onUpdate,
                onDelete: onDelete
            )
        );
        return this;
    }
    
    public CreateTableConfig AddReference(
        string columnName, 
        string referenceTable)
    {
        Table.AddReference(
            new Reference(
                columnName: columnName,
                referenceTable: _schema[referenceTable],
                referenceColumn: _schema[referenceTable]["id"],
                onUpdate: ReferenceOptions.NoAction,
                onDelete: ReferenceOptions.NoAction
            )
        );
        return this;
    }
}