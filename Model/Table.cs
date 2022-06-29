using System.Collections.Generic;

namespace FluentDB.Model;

public class Table
{
    private readonly string _tableName;

    private readonly Dictionary<string, Column> _columns;
    public Table(string tableName)
    {
        _tableName = tableName;
        _columns = new Dictionary<string, Column>();
    }

    public void AddColumn(ref Column column)
    {
        _columns.Add(column.ColumnName, column);
    }
}