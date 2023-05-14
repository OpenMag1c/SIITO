using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DAL.Interceptors;
internal sealed class AuditInterceptor : SaveChangesInterceptor
{
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        FillAuditColumns(eventData);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        FillAuditColumns(eventData);
        return base.SavingChanges(eventData, result);
    }

    private void FillAuditColumns(DbContextEventData eventData)
    {
        foreach (var entry in eventData!.Context!.ChangeTracker.Entries())
        {
            if (entry.Entity is AuditableEntity entity)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entity.CreatedAt = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entity.UpdatedAt = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
