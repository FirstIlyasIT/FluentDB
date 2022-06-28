namespace NHibFluent.Model
{
    public class NewTableConfig : BaseTableConfig
    {
        public NewTableConfig Default()
        {
            return this;
        }

        public NewTableConfig CanNull()
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