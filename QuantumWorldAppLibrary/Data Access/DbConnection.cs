using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace QuantumWorldAppLibrary.Data_Access;
public class DbConnection : IDbConnection
{
   private readonly IConfiguration _config;
   private readonly IMongoDatabase _db;
   private string _connectionId = "MongoDB";
   public string DbName { get; private set; }
   public string BuildingCollectionName { get; private set; } = "buildings";
   public string ResourceCollectionName { get; private set; } = "resources";
   public string UserCollectionName { get; private set; } = "users";
   public MongoClient Client { get; private set; }
   public IMongoCollection<BuildingModel> BuildingCollection { get; private set; }
   public IMongoCollection<ResourceModel> ResourceCollection { get; private set; }
   public IMongoCollection<UserModel> UserCollection { get; private set; }

   public DbConnection(IConfiguration config)
   {
      _config = config;
      Client = new MongoClient(_config.GetConnectionString(_connectionId));
      DbName = _config["DatabaseName"];
      _db = Client.GetDatabase(DbName);

      BuildingCollection = _db.GetCollection<BuildingModel>(BuildingCollectionName);
      ResourceCollection = _db.GetCollection<ResourceModel>(ResourceCollectionName);
      UserCollection = _db.GetCollection<UserModel>(UserCollectionName);
   }

}
