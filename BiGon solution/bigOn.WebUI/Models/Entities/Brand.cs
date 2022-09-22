using bigOn.WebUI.AppCode.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace bigOn.WebUI.Models.Entities
{
    public class Brand : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        

    }
}
