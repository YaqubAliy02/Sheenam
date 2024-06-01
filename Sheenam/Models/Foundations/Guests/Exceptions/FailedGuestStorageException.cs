using Xeptions;

namespace Sheenam.Models.Foundations.Guests.Exceptions
{
    public class FailedGuestStorageException : Xeption
    {
        public FailedGuestStorageException(Exception innerException)
            : base(message: "Failed guest storage error occured, contact support",
                  innerException)
        { }
    }
}
