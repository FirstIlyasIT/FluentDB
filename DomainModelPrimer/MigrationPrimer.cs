using System;
using FluentDB.Model;

namespace FluentDB.DomainModelPrimer;

public class MigrationPrimer: NHibFluentModel
{
    public MigrationPrimer(
        string connection, 
        Version currentVersion,
        Version targetVersion) : base(connection, currentVersion, targetVersion)
    {
        CreateTable(tableName: "employee")
            .PrimaryKey(columnName: "id", autoIncrement: true, startAutoIncrement: 1)
            .AddColumn(columnName: "name", columnType: new char[15], canNull: false)
            .AddColumn(columnName: "post", columnType: typeof(Post), canNull: true);

        CreateTable(tableName: "Task")
            .PrimaryKey(columnName: "id", autoIncrement: true, startAutoIncrement: 1)
            .AddReference(
                columnName: "employee_id",
                referenceTable: "employee",
                referenceColumn: "id",
                onUpdate: ForeignKeyOptions.NoAction,
                onDelete: ForeignKeyOptions.Cascade)
            .AddColumn(columnName: "description", columnType: typeof(string), canNull: true);

        EndMigration(new Version(1, 0));
    }
}