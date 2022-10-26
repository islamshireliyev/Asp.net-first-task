using bigOn.WebUI.AppCode.Infrastructure;
using System.Collections.Generic;

namespace bigOn.WebUI.Models.Entities
{
    public class ProductMaterial:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductCatalogItem> ProductCatalog { get; set; }

    }
}
