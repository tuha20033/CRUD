using CoreBusiness;
using Infrastructure.Plugins1.Context;
using Microsoft.EntityFrameworkCore;
using UseCase.PluginInterface;


namespace Plugins.InMemory;

public class InventoryRepository : IInventoryRepository
{
    private readonly DemoDatabase _context;
    public InventoryRepository(IDbContextFactory<DemoDatabase> factory)
    {
        _context = factory.CreateDbContext();
    }
  

    public async Task AddAsync(Inventory inventory, CancellationToken ct)
    {
        await _context.Inventories.AddAsync(inventory,ct);
        await _context.SaveChangesAsync(ct);
    }

    public async Task DeleteByIdAsync(int id, CancellationToken ct)
    {
        var inventories = await GetByIdAsync(id, ct);
        if (inventories is not null)
        {
             _context.Inventories.Remove(inventories);
            await _context.SaveChangesAsync(ct);
        }
    }

    public Task<List<Inventory>> GetAllAsync()
    {
        var inventories = _context.Inventories.ToList();
        return Task.FromResult(inventories);
    }

    public async Task<Inventory?> GetByIdAsync(int id, CancellationToken ct)
    {
        var inventories = await _context.Inventories.FirstOrDefaultAsync(c => c.InventoryId == id,ct);
        return inventories;
    }

    public Task Update(Inventory inventory, CancellationToken ct)
    {
       _context.Entry(inventory).State = EntityState.Modified;
        return _context.SaveChangesAsync(ct);
    }

    //public Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
    //{
    //    return;
    //}
}
//git
