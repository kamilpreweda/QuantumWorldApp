
namespace QuantumWorldAppLibrary.Models;
public class UserModel
{
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]
   public string ObjectIdentifier { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string DisplayName { get; set; }
   public string EmailAddress { get; set; }
   public List<BuildingModel> Buildings { get; set; }
   public List<ResourceModel> Resources { get; set; }
   public int Points { get; set; }

}
