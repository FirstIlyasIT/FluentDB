using System;
using FluentDB.Enums;
using FluentDB.FluentMigration;
using FluentDB.Model;

namespace FluentDB;

public class FluentModelMigration
{
    #region privateFields

    private readonly string _connection;
    private readonly TypeDb _typeDb;
    private DataBaseSchema _currentDataBaseSchema;
    private readonly DataBaseSchemas _schemas;
    private readonly Version _currentVersion;
    private readonly Version _targetVersion;

    #endregion

    #region ctor

    protected FluentModelMigration(
        string connection, 
        TypeDb typeDb, 
        Version currentVersion,
        Version targetVersion)
    {
        _connection = connection;
        _typeDb = typeDb;
        _currentVersion = currentVersion;
        _targetVersion = targetVersion;
        _currentDataBaseSchema = new DataBaseSchema();
        _schemas = new DataBaseSchemas();
    }

    #endregion

    #region TablesConfig

    protected CreateTableConfig CreateTable(string tableName)
    {
        var table = new Table(tableName);
        _currentDataBaseSchema.AddTable(table);
        return new CreateTableConfig(table, _currentDataBaseSchema);
    }

    protected AlterTableConfig AlterTable(string tableName)
    {
        var table = _currentDataBaseSchema[tableName];
        return new AlterTableConfig(table);
    }

    protected DropTableConfig DropTable(string tableName)
    {
        var table = _currentDataBaseSchema[tableName];
        return new DropTableConfig(table, _currentDataBaseSchema);
    }

    #endregion

    #region Migrations

    protected void EndMigration(Version  version)
    {
        _schemas.AddSchema(version, _currentDataBaseSchema);
        _currentDataBaseSchema = new DataBaseSchema(_currentDataBaseSchema);
    }

    #endregion

    #region protectedMethods

    protected void Finish()
    {
        
    }

    #endregion
}