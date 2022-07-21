using System.Collections.Generic;

namespace FluentDB.Model;

public class Table
{
    internal string Name { get; set; }
    
    private readonly Dictionary<string, Column> _columns;
    
    private readonly Dictionary<string, Reference> _references;
    
    internal PrimaryKey PrimaryKey { get; private set; }

    internal bool Erased { get; set; }
    
    internal bool ErasedIfExist { get; set; }
    
    internal Table(string name)
    {
        Name = name;
        _columns = new Dictionary<string, Column>();
        _references = new Dictionary<string, Reference>();
    }

    internal void AddColumn(Column column)
    {
        _columns.Add(column.Name, column);
    }

    public void SetPrimaryKey(PrimaryKey primaryKey)
    {
        PrimaryKey = primaryKey;
    }

    public void AddReference(Reference reference)
    {
        _references.Add(reference.ColumnName, reference);
    }

    public Column this[string column] => _columns[column];

    public void DropColumn(Column column)
    {
        _columns.Remove(column.Name);
    }
}