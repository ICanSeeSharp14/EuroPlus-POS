using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Petrol_Pump_Point_Of_Sale_System.Entities
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
        public int AccessType { get; set; }
        public UserType UserType { get; set; }

        public int RoleId { get; set; }

        //[ForeignKey("RoleId")]
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }


    }
}
