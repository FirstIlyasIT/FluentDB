using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentDB.Model;

public class DataBaseSchemas
{
    private readonly Dictionary<Version, DataBaseSchema> _schemas;

    public DataBaseSchemas()
    {
        _schemas = new Dictionary<Version, DataBaseSchema>();
    }

    public void AddSchema(Version version, DataBaseSchema dataBaseSchema)
    {
        _schemas.Add(version, dataBaseSchema);
    }

    public IEnumerable<string> GetScripts(Version currentVersion, Version targetVersion) 
        => _schemas
            .Where(s => s.Key > currentVersion 
                        && s.Key == targetVersion)
            .Select(schema => schema.Value.GetScript());
}