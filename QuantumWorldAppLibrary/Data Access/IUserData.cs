namespace QuantumWorldAppLibrary.Data_Access;

public interface IUserData
{
   Task CreateUser(UserModel user);
   Task<UserModel> GetUser(string id);
   Task<UserModel> GetUserFromAuthentication(string objectId);
   Task<List<UserModel>> GetUsersAsync();
   Task UpdateUser(UserModel user);
}