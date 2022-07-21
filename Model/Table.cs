using System.Collections.Generic;

namespace FluentDB.Model;

public class Table
{
    internal string Name { get; set; }
    
    private readonly Dictionary<string, Column> _columns;
    
    internal PrimaryKey PrimaryKey { get; private set; }

    internal bool Erased { get; set; }
    
    internal bool ErasedIfExist { get; set; }
    
    internal Table(string name)
    {
        Name = name;
        _columns = new Dictionary<string, Column>();
    }

    internal void AddColumn(Column column)
    {
        _columns.Add(column.Name, column);
    }

    public void SetPrimaryKey(PrimaryKey primaryKey)
    {
        PrimaryKey = primaryKey;
    }
}