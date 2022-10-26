using bigOn.WebUI.AppCode.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace bigOn.WebUI.Models.Entities
{
    public class Faq:BaseEntity
    {
        [Required]
        public string Question { get; set; }
        [Required]

        public string Answer { get; set; }
    }
}
