using Microsoft.EntityFrameworkCore;
using OwnedTypeTest.Data.Models;

namespace OwnedTypeTest.Data;

public class MyDbContext : DbContext
{

    public DbSet<EntityOwnsOneTableSplitting> WithOnes { get; set; }
    public DbSet<EntityOwnsOneToTable> WithOnesToTables { get; set; }
    public DbSet<EntityOwnsOneOfEach> WithBoth { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntityOwnsOneTableSplitting>()
            .OwnsOne(e => e.OwnedType);

        modelBuilder.Entity<EntityOwnsOneToTable>()
            .OwnsOne(e => e.OwnedTypeWithTable).ToTable("OwnedTypes");

        modelBuilder.Entity<EntityOwnsOneOfEach>().OwnsOne(e => e.OwnedType);
        modelBuilder.Entity<EntityOwnsOneOfEach>()
            .OwnsOne(e => e.OwnedTypeTwoWithTable).ToTable("OwnedTypeTwos");

        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 1, Name = "Alpha", Address = "a@alpha.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 2, Name = "Bravo", Address = "b@bravo.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 3, Name = "Charlie", Address = "c@charlie.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 4, Name = "Delta", Address = "d@delta.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 5, Name = "Echo", Address = "e@echo.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 6, Name = "Foxtrot", Address = "f@foxtrot.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 7, Name = "Golf", Address = "g@golf.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 8, Name = "Hotel", Address = "h@hotel.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 9, Name = "India", Address = "i@india.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 10, Name = "Juliet", Address = "j@juliet.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 11, Name = "Kilo", Address = "k@kilo.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 12, Name = "Lima", Address = "l@lima.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 13, Name = "Mike", Address = "m@mike.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 14, Name = "November", Address = "n@november.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 15, Name = "Oscar", Address = "o@oscar.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 16, Name = "Papa", Address = "p@papa.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 17, Name = "Quebec", Address = "q@quebec.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 18, Name = "Romeo", Address = "r@romeo.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 19, Name = "Sierra", Address = "s@sierra.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 20, Name = "Tango", Address = "t@tango.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 21, Name = "Uniform", Address = "u@uniform.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 22, Name = "Victor", Address = "v@victor.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 23, Name = "Whiskey", Address = "w@whiskey.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 24, Name = "X-Ray", Address = "x@x-ray.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 25, Name = "Yankee", Address = "y@yankee.com" });
        modelBuilder.Entity<EntityOwnsOneTableSplitting>().HasData(new EntityOwnsOneTableSplitting { Id = 26, Name = "Zulu", Address = "z@zulu.com" });

        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 1, Name = "Alpha", Address = "a@alpha.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 2, Name = "Bravo", Address = "b@bravo.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 3, Name = "Charlie", Address = "c@charlie.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 4, Name = "Delta", Address = "d@delta.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 5, Name = "Echo", Address = "e@echo.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 6, Name = "Foxtrot", Address = "f@foxtrot.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 7, Name = "Golf", Address = "g@golf.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 8, Name = "Hotel", Address = "h@hotel.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 9, Name = "India", Address = "i@india.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 10, Name = "Juliet", Address = "j@juliet.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 11, Name = "Kilo", Address = "k@kilo.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 12, Name = "Lima", Address = "l@lima.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 13, Name = "Mike", Address = "m@mike.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 14, Name = "November", Address = "n@november.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 15, Name = "Oscar", Address = "o@oscar.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 16, Name = "Papa", Address = "p@papa.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 17, Name = "Quebec", Address = "q@quebec.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 18, Name = "Romeo", Address = "r@romeo.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 19, Name = "Sierra", Address = "s@sierra.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 20, Name = "Tango", Address = "t@tango.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 21, Name = "Uniform", Address = "u@uniform.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 22, Name = "Victor", Address = "v@victor.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 23, Name = "Whiskey", Address = "w@whiskey.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 24, Name = "X-Ray", Address = "x@x-ray.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 25, Name = "Yankee", Address = "y@yankee.com" });
        modelBuilder.Entity<EntityOwnsOneOfEach>().HasData(new EntityOwnsOneOfEach { Id = 26, Name = "Zulu", Address = "z@zulu.com" });

        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 1, Name = "Alpha", Address = "a@alpha.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 2, Name = "Bravo", Address = "b@bravo.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 3, Name = "Charlie", Address = "c@charlie.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 4, Name = "Delta", Address = "d@delta.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 5, Name = "Echo", Address = "e@echo.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 6, Name = "Foxtrot", Address = "f@foxtrot.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 7, Name = "Golf", Address = "g@golf.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 8, Name = "Hotel", Address = "h@hotel.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 9, Name = "India", Address = "i@india.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 10, Name = "Juliet", Address = "j@juliet.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 11, Name = "Kilo", Address = "k@kilo.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 12, Name = "Lima", Address = "l@lima.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 13, Name = "Mike", Address = "m@mike.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 14, Name = "November", Address = "n@november.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 15, Name = "Oscar", Address = "o@oscar.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 16, Name = "Papa", Address = "p@papa.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 17, Name = "Quebec", Address = "q@quebec.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 18, Name = "Romeo", Address = "r@romeo.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 19, Name = "Sierra", Address = "s@sierra.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 20, Name = "Tango", Address = "t@tango.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 21, Name = "Uniform", Address = "u@uniform.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 22, Name = "Victor", Address = "v@victor.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 23, Name = "Whiskey", Address = "w@whiskey.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 24, Name = "X-Ray", Address = "x@x-ray.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 25, Name = "Yankee", Address = "y@yankee.com" });
        modelBuilder.Entity<EntityOwnsOneToTable>().HasData(new EntityOwnsOneToTable { Id = 26, Name = "Zulu", Address = "z@zulu.com" });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost;database=TestOwnedDb;trusted_connection=true;");
    }
}