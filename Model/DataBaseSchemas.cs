using System;
using System.Collections.Generic;

namespace FluentDB.Model;

public class DataBaseSchemas
{
    #region privateFields

    private readonly SortedDictionary<Version, DataBaseSchema> _schemas;

    #endregion

    #region ctor

    internal DataBaseSchemas()
    {
        _schemas = new SortedDictionary<Version, DataBaseSchema>();
    }

    #endregion

    #region ShemasMethods

    internal void AddSchema(Version version, DataBaseSchema dataBaseSchema)
    {
        _schemas.Add(version, dataBaseSchema);
    }

    #endregion
}