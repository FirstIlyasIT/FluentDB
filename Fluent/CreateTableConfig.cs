using System;
using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.Fluent;

public class CreateTableConfig : BaseTableConfig
{
    public CreateTableConfig(TypeDb typeDb, Table table) : base(typeDb, table)
    {
    }

    public CreateTableConfig AddColumn(
        string columnName, 
        Type columnType,
        bool canNull, 
        object defaultValue = null, 
        string namePreviousColumn = null)
    {
        return this;
    }
    
    public CreateTableConfig AddColumn<TArrayType>(
        string columnName, 
        TArrayType[] columnType, 
        bool canNull, 
        object defaultValue = null, 
        string namePreviousColumn = null)
    {
        return this;
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
        ForeignKeyOptions onUpdate, 
        ForeignKeyOptions onDelete)
    {
        return this;
    }
}