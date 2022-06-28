using System;

namespace NHibFluent.Model
{
    public class NHibFluentModel
    {
        protected NHibFluentModel(string connection, Version currentVersion)
        {
            
        }

        protected AlterTableConfig AlterTable(string tableName)
        {
            return new AlterTableConfig(tableName);
        }

        public NewTableConfig CreateTable()
        {
            return new NewTableConfig();
        }

        public DropTableConfig DropTable()
        {
            return new DropTableConfig();
        }
    }
}