using FluentDB.Enums;

namespace FluentDB.Model;

public class Reference
{

    #region internalFields

    internal string ColumnName { get; }

    internal Table referenceTable { get; }
    
    internal PrimaryKey ReferenceKey { get; }
    
    internal ReferenceOptions OnUpdate { get; }
    
    internal ReferenceOptions OnDelete { get; }

    #endregion

    #region ctor

    public Reference(string columnName,
        Table referenceTable,
        PrimaryKey referenceKey,
        ReferenceOptions onUpdate,
        ReferenceOptions onDelete)
    {
        ColumnName = columnName;
        ReferenceKey = referenceKey;
        OnUpdate = onUpdate;
        OnDelete = onDelete;
    }

    #endregion
}