using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugBase
{
    public class ReadFromAStream
    {
        public static void ReadFromAStreamFunc()
        {
            string manyLines = @"This is line one
This is line two
Here is line three
The penultimate line is line four
This is the final, fifth line.";

            using (var reader = new StringReader(manyLines))
            {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }
        }
    }
}
