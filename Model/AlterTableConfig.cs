using System;

namespace NHibFluent.Model
{
    public class AlterTableConfig: BaseTableConfig
    {
        public AlterTableConfig(string tableName)
        {
            Config = $"ALTER TABLE {tableName}";
        }
        public AddColumnConfig AddColumn(string columnName, Type columnType, bool canNull)
        {
            Config += $"ADD COLUMN {columnName} {TypeResolve(columnType)} {CanNull(canNull)}";
            return new AddColumnConfig(this);
        }
        
        public AlterTableConfig DropColumn()
        {
            return this;
        }

        public AlterTableConfig ChangeColumn()
        {
            return this;
        }

        private string TypeResolve(Type type)
        {
            if (type == typeof(string))
            {
                return "TEXT";
            }
            else
            {
                throw new Exception();
            }
        }

        private string CanNull(bool canNull)
        {
            return canNull ? "NULL" : String.Empty;
        }
    }
}