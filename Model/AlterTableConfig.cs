using System;
using System.Linq;

namespace NHibFluent.Model
{
    public class AlterTableConfig: BaseTableConfig
    {
        public AlterTableConfig(string tableName)
        {
            Config = $"ALTER TABLE {tableName}";
        }
        
        public ColumnConfig AddColumn<TArray>(
            string columnName, 
            TArray[] columnType, 
            bool canNull)
        {
            Config += $"ADD COLUMN {columnName} " +
                      $"{TypeResolve(typeof(TArray))}({columnType.Length})" +
                      $"{CanNull(canNull)}";
            return new ColumnConfig(this);
        }
        public ColumnConfig AddColumn(string columnName, Type columnType, bool canNull)
        {
            Config += $"ADD COLUMN {columnName} " +
                      $"{TypeResolve(columnType)} {CanNull(canNull)}";
            return new ColumnConfig(this);
        }
        
        public AlterTableConfig ChangeColumn<TArray>(
            string oldColumnName, 
            string newColumnName, 
            TArray[] columnType, 
            bool canNull)
        {
            Config += $"CHANGE COLUMN {oldColumnName} {newColumnName} " +
                      $"{TypeResolve(typeof(TArray))}({columnType.Length})" +
                      $"{CanNull(canNull)}";
            return this;
        }
        
        public ColumnConfig ChangeColumn(
            string oldColumnName, 
            string newColumnName, 
            Type columnType, 
            bool canNull)
        {
            Config += $"CHANGE COLUMN {oldColumnName} {newColumnName} " +
                      $"{TypeResolve(columnType)} {CanNull(canNull)}";
            return new ColumnConfig(this);
        }
        
        public AlterTableConfig DropColumn()
        {
            return this;
        }

        private string TypeResolve(Type type) {
            if (type == typeof(string))
                return "TEXT";
            if(type == typeof(char))
                return "VARCHAR";
            if (type == typeof(bool))
                return "TINYINT(1)";
            if (type == typeof(Enum))
                return $"ENUM({String.Join(',', Enum.GetNames(type))})";
            throw new ArgumentOutOfRangeException($"{type} not support");
        }

        private string CanNull(bool canNull) 
            => canNull ? "NULL" : "NOT NULL";
    }
}