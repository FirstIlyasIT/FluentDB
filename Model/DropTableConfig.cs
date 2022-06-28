namespace NHibFluent.Model
{
    public class DropTableConfig : BaseTableConfig
    {
        public DropTableConfig IfExist()
        {
            return this;
        }
    }
}