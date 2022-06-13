namespace NHibFluent.Model
{
    public class AlterTableConfig: NewTableConfig
    {
        public AlterTableConfig DropColumn()
        {
            return this;
        }

        public AlterTableConfig ChangeColumn()
        {
            return this;
        }

        public AlterTableConfig AfterColumn()
        {
            return this;
        }
    }
}