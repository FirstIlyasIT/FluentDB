using System.Collections.Generic;

namespace FluentDB.Model;

public class Table
{
    #region internalFields

    internal string Name { get; }
    
    internal PrimaryKey PrimaryKey { get; private set; }
    
    internal bool Erased { get; }

    #endregion

    #region privateFields

    private readonly Dictionary<string, Column> _columns;
    
    private readonly Dictionary<string, Reference> _references;

    #endregion

    #region ctor

    internal Table(string name)
    {
        Name = name;
        _columns = new Dictionary<string, Column>();
        _references = new Dictionary<string, Reference>();
    }

    #endregion

    #region ColumnMethods

    internal void AddColumn(Column column)
    {
        _columns.Add(column.Name, column);
    }

    public void DropColumn(Column column)
    {
        _columns.Remove(column.Name);
    }

    #endregion

    #region PrimaryKeyMethods

    public void SetPrimaryKey(PrimaryKey primaryKey)
    {
        PrimaryKey = primaryKey;
    }

    #endregion

    #region referencesMethods

    public void AddReference(Reference reference)
    {
        _references.Add(reference.ColumnName, reference);
    }

    #endregion

    #region indexers

    public Column this[string column] => _columns[column];

    #endregion

    #region Methods

    internal Table GetClone()
    {
        var clone = new Table(Name);
        clone.SetPrimaryKey(PrimaryKey.GetClone());
        foreach (var column in _columns)
        {
            clone.AddColumn(column.Value.GetClone());
        }

        foreach (var reference in _references)
        {
            clone.AddReference(reference.Value.GetClone());
        }
        return clone;
    }

    #endregion
}