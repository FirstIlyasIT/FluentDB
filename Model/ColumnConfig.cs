namespace FluentDB.Model;

public class ColumnConfig
{
    private readonly AlterTableConfig _alterTableConfig;
    public ColumnConfig(AlterTableConfig alterTableConfig)
    {
        _alterTableConfig = alterTableConfig;
    }

    public ColumnConfig DefaultValue(object value)
    {
        return this;
    }

    public ColumnConfig AfterColumn(string namePreviousColumn)
    {
        return this;
    }
}