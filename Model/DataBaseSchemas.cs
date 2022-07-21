using System;
using System.Collections.Generic;

namespace FluentDB.Model;

public class DataBaseSchemas
{
    private readonly SortedDictionary<Version, DataBaseSchema> _schemas;
    internal DataBaseSchemas()
    {
        _schemas = new SortedDictionary<Version, DataBaseSchema>();
    }

    internal void AddSchema(Version version, DataBaseSchema dataBaseSchema)
    {
        _schemas.Add(version, dataBaseSchema);
    }
}