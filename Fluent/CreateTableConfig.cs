using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.Fluent;

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
        var column = new Column();
        Table.AddColumn(ref column);
        return this;
    }
    
    public CreateTableConfig AddColumn<TType>(
        string columnName,
        bool canNull)
    {
        return AddColumn<TType>(columnName: columnName, canNull: canNull, defaultValue: default);
    }

    public CreateTableConfig PrimaryKey<TType>(
        string columnName, 
        bool autoIncrement, 
        TType startAutoIncrement)
    {
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