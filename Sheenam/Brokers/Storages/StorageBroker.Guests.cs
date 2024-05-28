using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Sheenam.Models.Foundations.Guests;
using System.Runtime.CompilerServices;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest>  Guests { get; set; }

        public async ValueTask<Guest> InsertGuestAsync(Guest guest)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Guest> guestEntityEntry =
                await broker.Guests.AddAsync(guest);

            await broker.SaveChangesAsync();

            return guestEntityEntry.Entity;
        }
    }
}
