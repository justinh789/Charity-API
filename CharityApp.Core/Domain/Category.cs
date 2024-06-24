using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CharityApp.Core.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MobileIconName  { get; set; } // <icon_library_name>.<icon_name> e.g. FontAwesome6.house-flood-water translates to <FontAwesome6 name="house-flood-water" />


        public virtual ICollection<Subcategory> Subcategories { get; } = new List<Subcategory>();

    }
}
