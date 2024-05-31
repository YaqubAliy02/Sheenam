//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using Xeptions;

namespace Sheenam.Models.Foundations.Guests.Exceptions
{
    public class AlreadyExistGuestException : Xeption
    {
        public AlreadyExistGuestException(Exception innerException)
            :base(message: "Guest already exist", innerException)
           { }
    }
}
