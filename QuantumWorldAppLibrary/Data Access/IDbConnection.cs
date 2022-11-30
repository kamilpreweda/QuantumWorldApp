using MongoDB.Driver;

namespace QuantumWorldAppLibrary.Data_Access;
public interface IDbConnection
{
   IMongoCollection<BuildingModel> BuildingCollection { get; }
   string BuildingCollectionName { get; }
   MongoClient Client { get; }
   string DbName { get; }
   IMongoCollection<ResourceModel> ResourceCollection { get; }
   string ResourceCollectionName { get; }
   IMongoCollection<UserModel> UserCollection { get; }
   string UserCollectionName { get; }
}