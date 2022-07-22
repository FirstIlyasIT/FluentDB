using System.Collections.Generic;

namespace FluentDB.Model;

public class DataBaseSchema
{

    #region privateFields

    private readonly Dictionary<string, Table> _tables;

    #endregion

    #region ctor

    internal DataBaseSchema(DataBaseSchema previousDataBaseSchema) : base()
    {
        
    }

    internal DataBaseSchema()
    {
        _tables = new Dictionary<string, Table>();
    }

    #endregion

    #region indexers

    internal Table this[string tableName] => _tables[tableName];

    #endregion

    #region tablesMethods

    internal void AddTable(Table table)
    {
        _tables.Add(table.Name, table);
    }

    public void DropTable(Table table)
    {
        _tables.Remove(table.Name);
    }

    #endregion
}