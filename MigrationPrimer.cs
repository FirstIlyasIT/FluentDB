using NHibFluent.Model;

namespace NHibFluent
{
    public class MigrationPrimer: NHibFluentModel
    {
        public MigrationPrimer()
        {
            AlterTable().AddColumn();
        }
    }
}