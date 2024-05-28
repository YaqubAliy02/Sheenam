using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.Guests;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest>  Guests { get; set; }
    }
}
