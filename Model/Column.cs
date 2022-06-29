namespace FluentDB.Model;

public struct Column
{
    private readonly string _columnType;

    private readonly bool _canNull;

    private readonly string _defaultValue;

    public string ColumnName { get; }

    public Column(
        string columnName, 
        string columnType, 
        bool canNull, 
        string defaultValue)
    {
        ColumnName = columnName;
        _columnType = columnType;
        _canNull = canNull;
        _defaultValue = defaultValue;
    }
}