namespace NHibFluent.Model
{
    public class NHibFluentModel
    {
        public AlterTableConfig AlterTable(string tableName)
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