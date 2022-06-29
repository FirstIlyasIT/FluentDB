using System;
using FluentDB.Fluent;
using FluentDB.Model;

namespace FluentDB;

public class FluentModelMigration
{
    private readonly TypeDb _typeDb;

    private DataBaseSchema _currentDataBaseSchema;

    private readonly DataBaseSchemas _schemas;
    
    protected FluentModelMigration(
        string connection, 
        TypeDb typeDb, 
        Version currentVersion,
        Version targetVersion)
    {
        _typeDb = typeDb;
        _schemas = new DataBaseSchemas();
        _currentDataBaseSchema = new DataBaseSchema();
    }

    protected AlterTableConfig AlterTable(string tableName)
    {
        return new AlterTableConfig(tableName, _typeDb, _currentDataBaseSchema);
    }

    public CreateTableConfig CreateTable(string tableName)
    {
        return new CreateTableConfig(tableName, _typeDb, _currentDataBaseSchema);
    }

    public DropTableConfig DropTable(string tableName)
    {
        return new DropTableConfig(tableName, _typeDb, _currentDataBaseSchema);
    }

    protected void EndMigration(Version  version)
    {
        _schemas.AddSchema(version, _currentDataBaseSchema);
        _currentDataBaseSchema = new DataBaseSchema();
    }
}