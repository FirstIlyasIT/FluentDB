using System.Collections.Generic;

namespace FluentDB.Model;

public class DataBaseSchema
{
    private readonly Dictionary<string, Table> _tables;

    internal DataBaseSchema(DataBaseSchema previousDataBaseSchema) : base()
    {
        
    }

    internal DataBaseSchema()
    {
        _tables = new Dictionary<string, Table>();
    }

    internal void AddTable(Table table)
    {
        _tables.Add(table.Name, table);
    }

    internal Table this[string tableName] => _tables[tableName];
}