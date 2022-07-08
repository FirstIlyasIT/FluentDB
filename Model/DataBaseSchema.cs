using System.Collections.Generic;

namespace FluentDB.Model;

public class DataBaseSchema
{
    private readonly Dictionary<string, Table> _tables;

    public DataBaseSchema(DataBaseSchema previousDataBaseSchema) : base()
    {
        
    }

    public DataBaseSchema()
    {
        _tables = new Dictionary<string, Table>();
    }

    public void AddTable(Table table)
    {
        _tables.Add(table.Name, table);
    }

    public Table this[string tableName] => _tables[tableName];

    public string GetScript()
    {
        throw new System.NotImplementedException();
    }
}