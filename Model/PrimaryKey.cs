using System;

namespace FluentDB.Model;

public class PrimaryKey
{
    #region privateFields

    private readonly string _columnName;
    private readonly Type _type;
    private readonly bool _autoIncrement;
    private readonly string _startAutoIncrement;

    #endregion

    #region ctor

    public PrimaryKey(
        string columnName,
        Type type,
        bool autoIncrement,
        string startAutoIncrement)
    {
        _columnName = columnName;
        _type = type;
        _autoIncrement = autoIncrement;
        _startAutoIncrement = startAutoIncrement;
    }

    #endregion
}