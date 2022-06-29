namespace FluentDB.Model;

public class Column
{
    private readonly string _columnName;
    
    public Column(string columnName)
    {
        _columnName = columnName;
    }
}