using System;

namespace NHibFluent.Model;

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

    public NewTableConfig CreateTable(string tableName)
    {
        return new NewTableConfig(tableName);
    }

    public DropTableConfig DropTable()
    {
        return new DropTableConfig();
    }

    protected void EndMigration(Version  newVersion)
    {
            
    }
}