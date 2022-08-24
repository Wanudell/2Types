using _2Types.Common;
using _2Types.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Types.Entities
{
    [Table("Users")]
    public class User : EntityBase
    {
        [Required]
        [MaxLength(107)] //Longest Name in the World
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(64)]
        public string Email { get; set; }

        [Required]
        [MaxLength(128)]
        public string Password { get; set; }

        [MaxLength(32)]
        public string PasswordHash { get; set; }

        public UserType UserType { get; set; }
    }
}