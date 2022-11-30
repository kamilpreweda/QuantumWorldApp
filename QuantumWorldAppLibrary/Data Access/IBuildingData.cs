namespace QuantumWorldAppLibrary.Data_Access;

public interface IBuildingData
{
   Task CreateBuilding(BuildingModel building);
   Task<List<BuildingModel>> GetAllBuildings();
}