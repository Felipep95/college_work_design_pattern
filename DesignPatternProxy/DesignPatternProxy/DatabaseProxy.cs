using System.Collections.Generic;

namespace DesignPatternProxy
{
    class DatabaseProxy : IDatabase
    {
        private Database _database = new Database();

        public void Select(string table, string fields, string where)
        {
            _database.Select(table, fields, where);
        }

        public void Update(string table, string fields, string where)
        {
            _database.Update(table, fields, where);
        }

        public void Insert(string table, List<string> fields, List<string> values)
        {
            _database.Insert(table, fields, values);
        }

        public void Delete(string table, int id)
        {
            _database.Delete(table, id);
        }
    }
}
