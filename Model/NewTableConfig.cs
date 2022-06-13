namespace NHibFluent.Model
{
    public class NewTableConfig
    {
        public NewTableConfig AddColumn()
        {
            return this;
        }

        public NewTableConfig Default()
        {
            return this;
        }

        public NewTableConfig NotNull()
        {
            return this;
        }

        public NewTableConfig PrimaryKey()
        {
            return this;
        }
    }
}