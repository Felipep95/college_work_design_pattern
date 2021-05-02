using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseProxy databaseProxy = new DatabaseProxy();

            var v1 = "table";
            var v2 = "field";
            var v3 = "where";
            var id = 1;

            List<string> fields = new List<string>()
            {
                "f1",
                "f2",
                "f3"
            };


            List<string> values = new List<string>()
            {
                "v1",
                "v2",
                "v3"
            };

            databaseProxy.Select(v1, v2, v3);
            Console.WriteLine();
            databaseProxy.Insert(v1, fields, values);
            Console.WriteLine();
            databaseProxy.Update(v1, v2, v3);
            Console.WriteLine();
            databaseProxy.Delete(v1, id);
        }
    }
}
