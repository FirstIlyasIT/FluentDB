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

    protected AlterTableConfig AlterTable(string tableName)
    {
        var table = new Table(tableName);
        return new AlterTableConfig(_typeDb, table);
    }

    public CreateTableConfig CreateTable(string tableName)
    {
        var table = _currentDataBaseSchema[tableName];
        return new CreateTableConfig(_typeDb, table);
    }

    public DropTableConfig DropTable(string tableName)
    {
        var table = _currentDataBaseSchema[tableName];
        return new DropTableConfig(_typeDb, table);
    }

    protected void EndMigration(Version  version)
    {
        _schemas.AddSchema(version, _currentDataBaseSchema);
        _currentDataBaseSchema = new DataBaseSchema(_currentDataBaseSchema);
    }

    protected void Finish()
    {
        StartMigration();
    }

    private void StartMigration()
    {
        var scripts = _schemas.GetScripts(_currentVersion, _targetVersion);
    }
}