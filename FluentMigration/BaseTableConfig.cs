using FluentDB.Model;

namespace FluentDB.FluentMigration;

public abstract class BaseTableConfig
{
    protected BaseTableConfig(Table table)
    {
        Table = table;
    }
    protected Table Table { get; }
}