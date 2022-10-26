using bigOn.WebUI.AppCode.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace bigOn.WebUI.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        [Required(ErrorMessage="{0} Bosh buraxila bilmez")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        public string Answer { get; set; }
        public int? AnswerByUserId { get; set; }
        public DateTime? AnswerDate { get; set; }



    }
}
