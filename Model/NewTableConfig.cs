namespace NHibFluent.Model;

public class NewTableConfig : BaseTableConfig
{
    public NewTableConfig(string tableName)
    {
        Config = "CREATE TABLE IF NOT EXISTS {tableName}";
    }

    public NewTableColumnConfig AddColumn(string columnName, bool canNull)
    {
        return new NewTableColumnConfig(this);
    }
}