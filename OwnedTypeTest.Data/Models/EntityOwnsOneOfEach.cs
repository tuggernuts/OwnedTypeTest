namespace OwnedTypeTest.Data.Models;

public class EntityOwnsOneOfEach
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public OwnedType? OwnedType { get; set; }
    public OwnedTypeTwoWithTable? OwnedTypeTwoWithTable { get; set; }
}