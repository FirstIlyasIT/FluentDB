namespace FluentDB.Model;

public class DropTableConfig : BaseTableConfig
{
    public DropTableConfig(string tableName)
    {
    }

    public DropTableConfig IfExist()
    {
        return this;
    }
}