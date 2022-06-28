namespace NHibFluent.Model;

public class ColumnConfig
{
    private readonly AlterTableConfig _alterTableConfig;
    public ColumnConfig(AlterTableConfig alterTableConfig)
    {
        _alterTableConfig = alterTableConfig;
    }

    public ColumnConfig DefaultValue(object value)
    {
        _alterTableConfig.Config += $"DEFAULT {value}";
        return this;
    }

    public ColumnConfig AfterColumn(string namePreviousColumn)
    {
        _alterTableConfig.Config += $"AFTER {namePreviousColumn}";
        return this;
    }
}