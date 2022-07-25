using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class CreateTableConfig : BaseTableConfig
{
    #region privateFields

    private readonly DataBaseSchema _schema;

    #endregion

    #region ctor

    public CreateTableConfig(Table table, DataBaseSchema currentDataBaseSchema) : base(table)
    {
        _schema = currentDataBaseSchema;
    }

    #endregion

    #region ColumnConfig

    #region AddColumn

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
                defaultValue: defaultValue?.ToString()
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

    #endregion

    #region primaryKey

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

    #endregion

    #region refences

    public CreateTableConfig AddReference(
        string columnName, 
        string referenceTable,
        ReferenceOptions onUpdate = ReferenceOptions.NoAction, 
        ReferenceOptions onDelete = ReferenceOptions.NoAction)
    {
        Table.AddReference(
            new Reference(
                columnName: columnName,
                referenceTable: _schema[referenceTable],
                referenceKey: _schema[referenceTable].PrimaryKey,
                onUpdate: onUpdate,
                onDelete: onDelete
            )
        );
        return this;
    }

    #endregion

    #endregion
}