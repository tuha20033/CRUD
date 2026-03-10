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
    public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
    {
       return await inventoryRepository.GetInventoriesByNameAsync(name);
    }
}
