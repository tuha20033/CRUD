using CoreBusiness;
using UseCase.PluginInterface;

namespace UseCase.Inventories;

public class ViewInventortiesByNameUseCase : IViewInventortiesByNameUseCase
{
    private readonly IInventoryRepository inventoryRepository;

    public ViewInventortiesByNameUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public Task AddAsync(Inventory inventory)
    {
        throw new NotImplementedException();
    }

    //public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
    //{
    //   return await inventoryRepository.GetInventoriesByNameAsync(name);
    //}

    public Task<Inventory> GetByIdAsync(int id, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}
