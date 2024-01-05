using Identity.Application.Common.Interfaces;

namespace Identity.Infrastructure
{
    public class SystemDataTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
