namespace FluentDB.Model;

public class DropTableConfig : BaseTableConfig
{
    public DropTableConfig(string tableName, TypeDb typeDb) : base(typeDb)
    {
        
    }

    public DropTableConfig IfExist()
    {
        return this;
    }
}