using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Core
{
    public class Campaign
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Mission { get; set; }

        public int? Target { get; set; }

        public int? Current { get; set; }

        public DateTime? StartDateUTC { get; set; }

        public DateTime? EndDateUTC { get; set; }

        public int? StatusId { get; set; }
    }
}
