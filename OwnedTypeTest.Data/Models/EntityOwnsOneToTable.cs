namespace OwnedTypeTest.Data.Models;

public class EntityOwnsOneToTable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public OwnedTypeWithTable? OwnedTypeWithTable { get; set; }
}