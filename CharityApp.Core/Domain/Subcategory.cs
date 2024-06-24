using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityApp.Core.Domain
{
    public class Subcategory
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
