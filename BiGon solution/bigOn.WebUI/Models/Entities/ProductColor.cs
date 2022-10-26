using bigOn.WebUI.AppCode.Infrastructure;
using System.Collections.Generic;

namespace bigOn.WebUI.Models.Entities
{
    public class ProductColor :BaseEntity
    {
        public string Name { get; set; }
        public string Hex { get; set; }
        public virtual ICollection<ProductCatalogItem> ProductCatalog { get; set; }

    }
}
