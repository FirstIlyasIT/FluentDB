using FluentDB.Enums;
using FluentDB.Model;

namespace FluentDB.Fluent;

public class DropTableConfig : BaseTableConfig
{
    public DropTableConfig(TypeDb typeDb, Table table) : base(typeDb, table)
    {
        
    }

    public DropTableConfig IfExist()
    {
        return this;
    }
}