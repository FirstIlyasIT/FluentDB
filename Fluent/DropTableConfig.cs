using FluentDB.Model;

namespace FluentDB.Fluent;

public class DropTableConfig : BaseTableConfig
{
    public DropTableConfig(
        string tableName, 
        TypeDb typeDb, 
        DataBaseSchema dataBaseSchema) : base(typeDb, dataBaseSchema)
    {
        
    }

    public DropTableConfig IfExist()
    {
        return this;
    }
}