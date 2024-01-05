using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Identity.Domain.Common;

namespace Identity.Domain.Users
{
    public class User : Entity
    {
        public string Email { get; } = null!;
        public string FirstName { get; } = null!;
        public string LastName { get; } = null!;
        public string Password { get; } = null!;
        public User(
            Guid id,
            string firstName,
            string lastName,
            string email) : base(id)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
