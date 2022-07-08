using FluentDB.Model;

namespace FluentDB.Fluent;

public class BaseTableConfig
{
    protected BaseTableConfig(Table table)
    {
        Table = table;
    }
    protected Table Table { get; }
}