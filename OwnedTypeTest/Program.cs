

using Microsoft.EntityFrameworkCore;
using OwnedTypeTest.Data;


namespace OwnedTypeTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new MyDbContext();
            
            var splits = context.WithOnes
                .OrderBy(o => o.Id).Take(10).ToList(); // works
            var tables = context.WithOnesToTables
                .OrderBy(o => o.Id).Take(10).ToList(); // works
            var both = context.WithBoth
                .OrderBy(o => o.Id).Take(10).ToList(); // no bueno

        }

    }
}



