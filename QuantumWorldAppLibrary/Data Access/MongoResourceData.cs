using Microsoft.Extensions.Caching.Memory;

namespace QuantumWorldAppLibrary.Data_Access;
public class MongoResourceData : IResourceData
{
   private readonly IMongoCollection<ResourceModel> _resources;
   private readonly IMemoryCache _cache;
   private const string cacheName = "ResourceData";

   public MongoResourceData(IDbConnection db, IMemoryCache cache)
   {
      _cache = cache;
      _resources = db.ResourceCollection;
   }
   public async Task<List<ResourceModel>> GetAllResources()
   {
      var output = _cache.Get<List<ResourceModel>>(cacheName);
      if (output is null)
      {
         var results = await _resources.FindAsync(_ => true);
         output = results.ToList();

         _cache.Set(cacheName, output, TimeSpan.FromDays(1));
      }
      return output;
   }
   public Task CreateResource(ResourceModel resource)
   {
      return _resources.InsertOneAsync(resource);
   }
}

