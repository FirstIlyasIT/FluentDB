namespace FluentDB.Model;

public class Column
{
    private readonly string _columnName;

    private readonly string _columnType;

    private readonly bool _canNull;

    private readonly string _defaultValue;
    
    public Column(
        string columnName, 
        string columnType, 
        bool canNull, 
        string defaultValue)
    {
        _columnName = columnName;
        _columnType = columnType;
        _canNull = canNull;
        _defaultValue = defaultValue;
    }
}