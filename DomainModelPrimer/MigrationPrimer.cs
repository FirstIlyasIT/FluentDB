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
            .AddColumn(columnName: "id", canNull: false);
                
        EndMigration(new Version(1, 0));
    }
}