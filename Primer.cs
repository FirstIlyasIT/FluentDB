using NHibFluent.Cotr;

namespace NHibFluent
{
    public class Primer : NHibFluentModel
    {
        public Primer()
        {
            CreateDataBase().Create();
        }
    }
}