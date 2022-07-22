using FluentDB.Model;

namespace FluentDB.FluentMigration;

public abstract class BaseTableConfig
{
    #region ctor

    protected BaseTableConfig(Table table)
    {
        Table = table;
    }

    #endregion

    #region protectedFields

    protected Table Table { get; }

    #endregion
    
}