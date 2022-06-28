namespace NHibFluent.Model;

public class NewTableColumnConfig
{
    private readonly NewTableConfig _tableConfig;
    public NewTableColumnConfig(NewTableConfig newTableConfig)
    {
        _tableConfig = newTableConfig;
    }
}