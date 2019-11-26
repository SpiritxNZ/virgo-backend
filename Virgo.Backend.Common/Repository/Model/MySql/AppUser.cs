using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Virgo.Backend.Common.Repository.Model.Other;

namespace Virgo.Backend.Common.Repository.Model.MySql
{
    public class AppUser : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string UserEmail { get; set; }
        [Required]
        [EnumDataType(typeof(UserType))]
        public UserType UserType { get; set; }
    }
}
