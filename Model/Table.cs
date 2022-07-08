using System.Collections.Generic;

namespace FluentDB.Model;

public class Table
{
    public string Name { get; set; }
    private readonly Dictionary<string, Column> _columns;
    public Table(string name)
    {
        Name = name;
        _columns = new Dictionary<string, Column>();
    }

    public void AddColumn(ref Column column)
    {
        _columns.Add(column.Name, column);
    }
}