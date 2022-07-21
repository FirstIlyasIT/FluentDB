using FluentDB.Model;

namespace FluentDB.FluentMigration;

public class DropTableConfig : BaseTableConfig
{
    public DropTableConfig(Table table) : base(table)
    {
        
    }

    public DropTableConfig IfExist()
    {
        return this;
    }
}