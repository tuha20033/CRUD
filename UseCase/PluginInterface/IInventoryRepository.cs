using CoreBusiness;

namespace UseCase.PluginInterface;

public interface IInventoryRepository
{
    //Task<IEnumerable<CoreBusiness.Inventory>> GetInventoriesByNameAsync(string name);
    Task AddAsync(Inventory inventory, CancellationToken ct);
    Task <List<Inventory>> GetAllAsync();
    Task<Inventory?> GetByIdAsync(int id, CancellationToken ct);
    Task Update(Inventory inventory, CancellationToken ct);
    Task DeleteByIdAsync(int id, CancellationToken ct);
}
