﻿namespace T.Core
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Birthday { get; set; }

        public string Address { get; set; }
    }
}
