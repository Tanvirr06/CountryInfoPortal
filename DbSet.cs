using Microsoft.AspNetCore.Mvc;

public class DbSet<T>
{
    internal async Task<ActionResult<IEnumerable<Country>>> ToListAsync()
    {
        throw new NotImplementedException();
    }
}