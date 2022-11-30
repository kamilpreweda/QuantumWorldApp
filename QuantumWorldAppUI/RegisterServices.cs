namespace QuantumWorldAppUI;

public static class RegisterServices
{
   public static void ConfigureServices(this WebApplicationBuilder builder)
   {
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddMemoryCache();
      builder.Services.AddScoped<IDbConnection, DbConnection>();
      builder.Services.AddScoped<IBuildingData, MongoBuildingData>();
      builder.Services.AddScoped<IResourceData, MongoResourceData>();
      builder.Services.AddScoped<IUserData, MongoUserData>();

   }
}

   