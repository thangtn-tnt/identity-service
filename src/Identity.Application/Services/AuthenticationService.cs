﻿using Identity.Application.Common.Interfaces;

namespace Identity.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "", "", email, "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // check if user already exists
            // create new user (unique userid)
            // create jwt token
            var userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(userId, firstName, lastName, email, token);
        }
    }
}
