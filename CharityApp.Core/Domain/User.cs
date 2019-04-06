using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string FirstNames { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Cell { get; set; }

        public string PasswordHash { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public DateTime CreatedDateUTC { get; set; }

        public int StatusId { get; set; }
    }
}
