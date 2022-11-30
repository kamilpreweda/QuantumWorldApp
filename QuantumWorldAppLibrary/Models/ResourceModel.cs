
namespace QuantumWorldAppLibrary.Models;
public class ResourceModel
{
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string ResourceName { get; set; }
   public int ResourceValue { get; set; }
   public int ResourceMultiplier { get; set; }
}
