
using Microsoft.Extensions.Caching.Memory;

namespace QuantumWorldAppLibrary.Data_Access;
public class MongoBuildingData : IBuildingData
{
   private readonly IMongoCollection<BuildingModel> _buildings;
   private readonly IMemoryCache _cache;
   private const string cacheName = "BuildingData";


   public MongoBuildingData(IDbConnection db, IMemoryCache cache)
   {
      _cache = cache;
      _buildings = db.BuildingCollection;
   }
   public async Task<List<BuildingModel>> GetAllBuildings()
   {
      var output = _cache.Get<List<BuildingModel>>(cacheName);
      if (output is null)
      {
         var results = await _buildings.FindAsync(_ => true);
         output = results.ToList();

         _cache.Set(cacheName, output, TimeSpan.FromDays(1));
      }
      return output;
   }
   public Task CreateBuilding(BuildingModel building)
   {
      return _buildings.InsertOneAsync(building);
   }
}

