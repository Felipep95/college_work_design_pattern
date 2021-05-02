using System.Collections.Generic;

namespace DesignPatternProxy
{
    interface IDatabase
    {
        public void Select(string table, string fields, string where);

        public void Update(string table, string fields, string where);

        public void Insert(string table, List<string> fields, List<string> values);

        public void Delete(string table, int id);
    }
}
