//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------
using Sheenam.Models.Foundations.Guests;

namespace Sheenam.Services.Foundations.Guests
{
    public interface IGuestService
    {
        public ValueTask<Guest> AddGuestAsync(Guest guest);
    }
}
