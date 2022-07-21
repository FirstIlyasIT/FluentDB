using FluentDB.Enums;

namespace FluentDB.Model;

public class Reference
{
    internal string ColumnName { get; }

    private Table referenceTable { get; }
    
    private PrimaryKey ReferenceKey { get; }
    
    private ReferenceOptions onUpdate { get; }
    
    private ReferenceOptions onDelete { get; }

    public Reference(string columnName,
        Table referenceTable,
        PrimaryKey referenceKey,
        ReferenceOptions onUpdate,
        ReferenceOptions onDelete)
    {
        
    }
}