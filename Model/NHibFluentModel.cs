using System;

namespace FluentDB.Model;

public class NHibFluentModel
{
    protected NHibFluentModel(
        string connection, 
        Version currentVersion, 
        Version targetVersion)
    {
            
    }

    protected AlterTableConfig AlterTable(string tableName)
    {
        return new AlterTableConfig(tableName);
    }

    public CreateTableConfig CreateTable(string tableName)
    {
        return new CreateTableConfig(tableName);
    }

    public DropTableConfig DropTable(string tableName)
    {
        return new DropTableConfig(tableName);
    }

    protected void EndMigration(Version  newVersion)
    {
            
    }
}