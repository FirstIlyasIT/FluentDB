using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class DropTableConfig : BaseTableConfig
{
    private readonly DataBaseSchema _schema;
    public DropTableConfig(
        Table table, 
        DataBaseSchema currentDataBaseSchema
        ) : base(table)
    {
        _schema = currentDataBaseSchema;
    }

    public DropTableConfig Drop()
    {
        _schema.DropTable(Table);
        return this;
    }
}