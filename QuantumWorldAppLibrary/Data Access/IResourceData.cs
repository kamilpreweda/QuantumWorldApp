namespace QuantumWorldAppLibrary.Data_Access;

public interface IResourceData
{
   Task CreateResource(ResourceModel resource);
   Task<List<ResourceModel>> GetAllResources();
}