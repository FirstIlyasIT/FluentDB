using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class BaseTableConfig
{
    protected BaseTableConfig(Table table)
    {
        Table = table;
    }
    protected Table Table { get; }
}