namespace NHibFluent.Model
{
    public class NHibFluentModel
    {
        public AlterTableConfig AlterTable()
        {
            return new AlterTableConfig();
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