using System;
using FluentDB.Enums;
using FluentDB.Fluent;
using FluentDB.Model;

namespace FluentDB;

public class FluentModelMigration
{
    private readonly TypeDb _typeDb;
    private DataBaseSchema _currentDataBaseSchema;
    private readonly DataBaseSchemas _schemas;
    private readonly Version _currentVersion;
    private readonly Version _targetVersion;

    protected FluentModelMigration(
        string connection, 
        TypeDb typeDb, 
        Version currentVersion,
        Version targetVersion)
    {
        _typeDb = typeDb;
        _currentVersion = currentVersion;
        _targetVersion = targetVersion;
        _currentDataBaseSchema = new DataBaseSchema();
        _schemas = new DataBaseSchemas();
    }
    
    public CreateTableConfig CreateTable(string tableName)
    {
        var table = new Table(tableName);
        _currentDataBaseSchema.AddTable(table);
        return new CreateTableConfig(table);
    }

    protected AlterTableConfig AlterTable(string tableName)
    {
        var table = _currentDataBaseSchema[tableName];
        return new AlterTableConfig(table);
    }

    public DropTableConfig DropTable(string tableName)
    {
        var table = _currentDataBaseSchema[tableName];
        return new DropTableConfig(table);
    }

    protected void EndMigration(Version  version)
    {
        _schemas.AddSchema(version, _currentDataBaseSchema);
        _currentDataBaseSchema = new DataBaseSchema(_currentDataBaseSchema);
    }

    protected void Finish()
    {
        
    }
}