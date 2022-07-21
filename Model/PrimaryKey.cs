using System;

namespace FluentDB.Model;

public class PrimaryKey
{
    private string _columnName;
    private bool _autoIncrement;
    private object _startAutoIncrement;
    public PrimaryKey(
        string columnName,
        Type increment,
        bool autoIncrement,
        object startAutoIncrement)
    {
        _columnName = columnName;
        throw new System.NotImplementedException();
    }
}