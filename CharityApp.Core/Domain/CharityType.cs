using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Core.Domain
{
    public class CharityType
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public string TypeDescription { get; set; }

        public string Sector { get; set; }

        public string Service { get; set; }
    }
}
