﻿using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Xml.Linq;

namespace HTS.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int RoleId { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
