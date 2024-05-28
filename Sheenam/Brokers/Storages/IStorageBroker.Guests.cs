using Sheenam.Models.Foundations.Guests;

namespace Sheenam.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);

    }
}
