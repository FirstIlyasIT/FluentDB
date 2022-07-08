using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.Fluent;

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