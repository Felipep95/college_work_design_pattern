using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProxy
{
    class DatabaseProxy : IDatabase
    {
        private string sql;

        public void Select(string table, string fields, string where)
        {
            sql = $"SELECT {fields} FROM {table} {where} id = { new { id = 1 }}";
            Console.WriteLine($"{sql}");
        }

        public void Update(string table, string fields, string where)
        {
            sql = $"UPDATE {table} SET {fields} = { new { field = "new field" }} {where} id = { new { id = 1 }}";
            Console.WriteLine($"{sql}");
        }

        public void Insert(string table, List<string> fields, List<string> values)
        {
            StringBuilder strb = new StringBuilder();
            StringBuilder strb2 = new StringBuilder();

            strb.Append($"({fields})");
            strb2.Append($"({values})");

            for (int i = 0; i < fields.Count; i++)
            {
                strb.Append($"{fields[i]}, ");
            }

            for (int i = 0; i < values.Count; i++)
            {
                strb2.Append($"{values[i]}, ");
            }

            sql = $"INSERT INTO {table} ({strb}) VALUES ({strb2})";
            Console.WriteLine($"{sql}");

            //Console.WriteLine(
            //    $"INSERT INTO {table}" + 
            //    $"({strb})" +
            //    $"VALUES ({strb2})"
            //    );
        }

        public void Delete(string table, int id)
        {
            sql = $"DELETE FROM {table} WHERE id = {id}";
            Console.WriteLine($"{sql}");
        }
    }
}
