using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Core.Domain
{
    public class Status
    {
        public int Id { get; set; }

        public int StatusGroupId { get; set; }

        public string StatusGroupName { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
