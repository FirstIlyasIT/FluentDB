using System;
using System.Collections.Generic;

namespace FluentDB.Model;

public class DataBaseSchemas
{
    private readonly Dictionary<Version, DataBaseSchema> _schemas;
    private readonly Queue<Version> _versions;

    public DataBaseSchemas()
    {
        _schemas = new Dictionary<Version, DataBaseSchema>();
    }

    public void AddSchema(Version version, DataBaseSchema dataBaseSchema)
    {
        _schemas.Add(version, dataBaseSchema);
        _versions.Enqueue(version);
    }
}