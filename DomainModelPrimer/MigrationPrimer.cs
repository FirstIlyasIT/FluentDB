using System;
using NHibFluent.Model;

namespace NHibFluent.DomainModelPrimer
{
    public class MigrationPrimer: NHibFluentModel
    {
        public MigrationPrimer(
            string connection, 
            Version currentVersion) : base(connection, currentVersion)
        {
            AlterTable("my_table")
                .AddColumn(columnName: "name", columnType: typeof(string), canNull: true)
                .DefaultValue(value: null);
            
            AlterTable("my_table")
                .AddColumn(columnName: "name", columnType: new char[15], canNull: true)
                .DefaultValue(value: null);
            
            AlterTable("Employee")
                .ChangeColumn(
                    oldColumnName: "past",
                    newColumnName: "post",
                    columnType: typeof(Post),
                    canNull: false)
                .DefaultValue(Post.Cleaner);
        }
    }
}