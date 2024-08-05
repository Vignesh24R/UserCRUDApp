using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUDApp.DAL.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}
