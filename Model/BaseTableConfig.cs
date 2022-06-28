using System;

namespace FluentDB.Model;

public class BaseTableConfig
{
    private string TypeResolve(Type type)
    {
        throw new InvalidOperationException();
    }
}