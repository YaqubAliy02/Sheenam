//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using Sheenam.Models.Foundations.Guests;
using Sheenam.Models.Foundations.Guests.Exceptions;

namespace Sheenam.Services.Foundations.Guests
{
    public partial class GuestService
    {
        private void ValidateGuestNotNull(Guest guest)
        {
            if (guest is null)
                throw new NullGuestException();
        }
    }
}   
