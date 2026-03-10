namespace UseCase.PluginInterface;

public interface IInventoryRepository
{
    Task<IEnumerable<CoreBusiness.Inventory>> GetInventoriesByNameAsync(string name);
}
