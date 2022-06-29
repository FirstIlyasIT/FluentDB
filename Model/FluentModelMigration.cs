using System;

namespace FluentDB.Model;

public class FluentModelMigration
{
    private TypeDb _typeDb;
    
    protected FluentModelMigration(string connection, TypeDb typeDb, Version currentVersion)
    {
        _typeDb = typeDb;
    }

    protected AlterTableConfig AlterTable(string tableName)
    {
        return new AlterTableConfig(tableName, _typeDb);
    }

    public CreateTableConfig CreateTable(string tableName)
    {
        return new CreateTableConfig(tableName, _typeDb);
    }

    public DropTableConfig DropTable(string tableName)
    {
        return new DropTableConfig(tableName, _typeDb);
    }

    protected void EndMigration(Version  newVersion)
    {
            
    }
}