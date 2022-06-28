namespace NHibFluent.Model;

public class AddColumnConfig
{
    private readonly AlterTableConfig _alterTableConfig;
    public AddColumnConfig(AlterTableConfig alterTableConfig)
    {
        _alterTableConfig = alterTableConfig;
    }

    public AddColumnConfig DefaultValue(object value)
    {
        _alterTableConfig.Config += $"DEFAULT {value}";
        return this;
    }

    public AddColumnConfig AfterColumn(string namePreviousColumn)
    {
        _alterTableConfig.Config += $"AFTER {namePreviousColumn}";
        return this;
    }
}