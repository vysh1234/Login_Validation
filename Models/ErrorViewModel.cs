using System;
using System.ComponentModel.DataAnnotations;

namespace Login_Validation.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
