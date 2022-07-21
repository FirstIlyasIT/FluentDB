using System;

namespace FluentDB.Model;

public class PrimaryKey
{
    private string _columnName;
    private Type _type;
    private bool _autoIncrement;
    private string _startAutoIncrement;
    public PrimaryKey(
        string columnName,
        Type type,
        bool autoIncrement,
        string startAutoIncrement)
    {
        _columnName = columnName;
        _type = type;
        _autoIncrement = autoIncrement;
        _startAutoIncrement = startAutoIncrement;
    }
}