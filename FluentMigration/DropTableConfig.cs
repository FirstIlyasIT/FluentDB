using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class DropTableConfig : BaseTableConfig
{

    #region privateFields

    private readonly DataBaseSchema _schema;

    #endregion

    #region ctor

    public DropTableConfig(Table table, DataBaseSchema currentDataBaseSchema) : base(table)
    {
        _schema = currentDataBaseSchema;
    }

    #endregion

    #region Config

    #region Drop

    public DropTableConfig Drop()
    {
        _schema.DropTable(Table);
        return this;
    }

    #endregion

    #endregion
}