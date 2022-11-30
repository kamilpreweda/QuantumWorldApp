
namespace QuantumWorldAppLibrary.Models;

 public class BuildingModel
 {
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string BuildingName { get; set; }
   public string BuildingDescription { get; set; }
   public int BuildingLevel { get; set; }
   public int BuildingTimeToBuild { get; set; }
   public int BuildingCost { get; set; }
   public bool ApprovedToBuild { get; set; } = false;
}
