using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Core.Domain
{
    public class Donation
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int DonationTypeId { get; set; }

        public int? CharityId { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? UserRatingPLACEHOLDER { get; set; }

        public int? CharityRatingPLACEHOLDER { get; set; }
    }
}
