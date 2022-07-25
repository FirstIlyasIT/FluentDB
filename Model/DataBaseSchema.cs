using System.Collections.Generic;
using System.Linq;

namespace FluentDB.Model;

public class DataBaseSchema
{

    #region privateFields

    private readonly Dictionary<string, Table> _tables;

    #endregion

    #region ctor

    internal DataBaseSchema(DataBaseSchema previousDataBaseSchema)
    {
        _tables = previousDataBaseSchema.GetCopyTables();
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
    
    private Dictionary<string, Table> GetCopyTables()
    {
        return _tables
            .Where(table => !table.Value.Erased)
            .ToDictionary(table => table.Key, table => table.Value.GetClone());
    }

    #endregion
}