using bigOn.WebUI.AppCode.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace bigOn.WebUI.Models.Entities
{
    public class ProductSize:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string SmallName { get; set; }

    }
}
