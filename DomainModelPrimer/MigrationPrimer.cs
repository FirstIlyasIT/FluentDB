using System;
using NHibFluent.Model;

namespace NHibFluent.DomainModelPrimer;

public class MigrationPrimer: NHibFluentModel
{
    public MigrationPrimer(
        string connection, 
        Version currentVersion,
        Version targetVersion) : base(connection, currentVersion, targetVersion)
    {
        CreateTable(tableName: "employee")
            .PrimaryKey(columnName: "id", autoIncrement: true, startAutoIncrement: 1)
            .AddColumn(columnName: "name", canNull: false, columnType: new char[15])
            .AddColumn(columnName: "post", canNull: true, columnType: typeof(Post));

        EndMigration(new Version(1, 0));
    }
}