//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------
using Sheenam.Brokers.Storages;
using Sheenam.Models.Foundations.Guests;

namespace Sheenam.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;
        

        public ValueTask<Guest> AddGuestAsync(Guest guest) =>
           this.storageBroker.InsertGuestAsync(guest);
        
    }
}
